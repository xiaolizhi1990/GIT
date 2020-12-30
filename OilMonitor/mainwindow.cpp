#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QGridLayout>
#include <QtSerialPort/QSerialPort>
#include <QFile>
#include <QTextStream>
#include <QDebug>
#include <QString>
#include <QMessageBox>
#include <water.h>
#include <granule.h>
#include <sqlhelper.h>
#include <QCoreApplication>
#include <QSqlDatabase>
#include <QVariant>
#include <QDebug>
QTextStream cout(stdout,QIODevice::WriteOnly);



MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    //读取配置文件
    QFile file(":/resource/setting.txt");
    if(!file.open(QIODevice::ReadOnly|QIODevice::Text))
    {

        QMessageBox::information(this,"错误信息","读取配置文件失败");
        return;
    }
    QTextStream in(&file);
    while(!in.atEnd())
    {
        QString line=in.readLine();
        QStringList fields=line.split('$');

        if(fields.size()==2)
        {
            std::string name=fields.at(0).toStdString();
            std::string val=fields.at(1).toStdString();

            QString qName=QString::fromStdString(name).trimmed();
            QString qVal=QString::fromStdString(val).trimmed();

            if(qName=="localConnStr")
            {
               localConnStr=qVal;
            }
            if(qName=="waterCom")
            {
                waterCom=qVal;
            }

            if(qName=="waterRate")
            {
                waterRate=qVal.toInt();
            }

            if(qName=="waterOpen")
            {
                waterOpen=qVal.toInt()?true:false;
            }
            if(qName=="granularityCom")
            {
                granularityCom=qVal;
            }
            if(qName=="granularityRate")
            {
                granularityRate=qVal.toInt();
            }
            if(qName=="granularityOpen")
            {
                granularityOpen=qVal.toInt()?true:false;
            }
         }
     }
    //水分
    if(waterOpen)
    {
        waterSerialPort=new QSerialPort("\\\\.\\"+waterCom);
        waterSerialPort->open(QIODevice::ReadWrite);
        waterSerialPort->setBaudRate(waterRate);
        waterSerialPort->setParity(QSerialPort::NoParity);
        waterSerialPort->setDataBits(QSerialPort::Data8);
        waterSerialPort->setStopBits(QSerialPort::OneStop);
        waterSerialPort->setFlowControl(QSerialPort::NoFlowControl);
        QObject::connect(waterSerialPort,SIGNAL(readyRead()),this,SLOT(waterSerialPort_read()));
    }
    //颗粒污染度
    if(granularityOpen)
    {
        granSerialPort=new QSerialPort("\\\\.\\"+granularityCom);
        granSerialPort->open(QIODevice::ReadWrite);
        granSerialPort->setBaudRate(granularityRate);
        granSerialPort->setParity(QSerialPort::NoParity);
        granSerialPort->setDataBits(QSerialPort::Data8);
        granSerialPort->setStopBits(QSerialPort::OneStop);
        granSerialPort->setFlowControl(QSerialPort::NoFlowControl);
        QObject::connect(granSerialPort,SIGNAL(readyRead()),this,SLOT(granSerialPort_read()));

    }
    try
    {
        if(waterOpen)
        {
            waterSerialPort->open(QIODevice::ReadWrite);
            sqlHelper.initWater(sqlHelper.waterDB);
            sqlHelper.initWaterQuery(sqlHelper.waterQuery);

            waterTimer=new QTimer(this);
            QObject::connect(waterTimer,SIGNAL(timeout()),this,SLOT(waterSerialPort_write));
            waterTimer->start(3000);

        }
        if(granularityOpen)
        {
            granSerialPort->open(QIODevice::ReadWrite);
            bool open=sqlHelper.initGran(sqlHelper.granDB);
          //  sqlHelper.initGranQuery(sqlHelper.granQuery);
            granTimer=new QTimer(this);
            QObject::connect(granTimer,SIGNAL(timeout()),this,SLOT(granSerialPort_write()));
            granTimer->start(3000);
        }

    }
    catch(int e)
    {
        QMessageBox::information(this,"错误信息","串口或是数据库打开失败");
    }

}

void MainWindow::waterSerialPort_write()
{

     char* data=(char *)malloc(6*sizeof(char));
     data[0]=82;
     data[1]=86;
     data[2]=97;
     data[3]=108;
     data[4]=13;
     data[5]='\0';

     waterSerialPort->write(data);
}
void MainWindow::waterSerialPort_read()
{
    try
    {
        char *data;
        qint64  recvArray=waterSerialPort->readLine(data,1000);
        if(recvArray<1)return;
        QString result=data;

        if(!result.contains("CRC"))
            return;

        QStringList parameters= result.split(';');

        water paras;
        foreach(QString para,parameters)
        {
            std::string nameTemp=para.split(':').at(0).toStdString();
            std::string valTemp=para.split(':').at(1).toStdString();

            QString name=QString::fromStdString(nameTemp);
            QString val=QString::fromStdString(valTemp);

            if(name=="$Time")
            {
                paras.TimeDate=val;
                continue;
            }
            if(name=="T")
            {
                paras.T=val;
                continue;
            }
            if(name=="P")
            {
                paras.P=val;
                continue;
            }
            if(name=="P40")
            {
                paras.P40=val;
                continue;
            }
            if(name=="C")
            {
                paras.C=val;
                continue;
            }
            if(name=="C40")
            {
                paras.C40=val;
                continue;
            }
            if(name=="RH")
            {
                paras.RH=val;
                continue;
            }
            if(name=="RH20")
            {
                paras.RH20=val;
                continue;
            }
            if(name=="TMean")
            {
                paras.TMean=val;
                continue;
            }
            if(name=="PCBT")
            {
                paras.PCBT=val;
                continue;
            }
            if(name=="RULT")
            {
                paras.RULT=val;
                continue;
            }
            if(name=="RULLG")
            {
                paras.RULLG=val;
                continue;
            }
            if(name=="RUL")
            {
                paras.RUL=val;
                continue;
            }
            if(name=="APP40")
            {
                paras.APP40=val;
                continue;
            }
            if(name=="APC40")
            {
                paras.APC40=val;
                continue;
            }

            if(name=="AP")
            {
                paras.AP=val;
                continue;
            }
            if(name=="fB")
            {
                paras.fB=val;
                continue;
            }
            if(name=="OAge")
            {
                paras.OAge=val;
                continue;
            }

        }
        sqlHelper.insertWaterPara(paras);
    }
    catch(int e)
    {

    }

}
void MainWindow::granSerialPort_write()
{
    char* data=(char *)malloc(6*sizeof(char));
    data[0]=82;
    data[1]=86;
    data[2]=97;
    data[3]=108;
    data[4]=13;
    data[5]='\0';
    granSerialPort->write(data);
    qDebug()<<"写入一次";

}

QString result;
int i=0;

void MainWindow::granSerialPort_read()
{
    qDebug()<<"读入"<<i++<<"次";
    try
    {
       // char *data=(char *)malloc(1000*sizeof(char));

       // qint64 recvArray=granSerialPort->readLine(data,1000);

        QByteArray recvArray=granSerialPort->readAll();
        if(recvArray.length()<1) return;

        result+=recvArray.data();

        if(!result.contains('\x0d'))
            return;
        qDebug()<<result.toLatin1().data();

        QStringList parameters= result.split(';');
        result.clear();//将结果置为"";
        granule paras;
        foreach(QString para,parameters)
        {
            if(!para.contains(':'))break;

            QStringList list=para.split(':');

            std::string nameTemp=list.at(0).toStdString();
            std::string valTemp=list.at(1).toStdString();

            QString name=QString::fromStdString(nameTemp);
            QString val=QString::fromStdString(valTemp);
            if(name=="$Time")
            {
                paras.TimeDate=val;
                continue;
            }
            if(name=="ISO4um")
            {
                paras.ISO4um=val;
                continue;
            }
            if(name=="ISO6um")
            {
                paras.ISO6um=val;
                continue;
            }
            if(name=="ISO14um")
            {
                paras.ISO14um=val;
                continue;
            }
            if(name=="ISO21um")
            {
                paras.ISO21um=val;
                continue;
            }


            if(name=="SAE4um")
            {
                paras.SAE4um=val;
                continue;
            }
            if(name=="SAE6um")
            {
                paras.SAE6um=val;
                continue;
            }
            if(name=="SAE14um")
            {
                paras.SAE14um=val;
                continue;
            }
            if(name=="SAE21um")
            {
                paras.SAE21um=val;
                continue;
            }


            if(name=="NAS")
            {
                paras.NAS=val;
                continue;
            }
            if(name=="GOST")
            {
                paras.GOST=val;
                continue;
            }
            if(name=="Conc4um")
            {
                paras.Conc4um=val;
                continue;
            }
            if(name=="Conc6um")
            {
                paras.Conc6um=val;
                continue;
            }


            if(name=="Conc14um")
            {
                paras.Conc14um=val;
                continue;
            }
            if(name=="Conc21um")
            {
                paras.Conc21um=val;
                continue;
            }

            if(name=="FIndex")
            {
                paras.FIndex=val;
                continue;
            }
            if(name=="MTime")
            {
                paras.MTime=val;
                continue;
            }

        }

       bool insertSuccess=sqlHelper.insertGranPara(paras);
        qDebug()<<(insertSuccess?"成功":"失败");


    }
    catch(int e)
    {
        qDebug()<<e;
    }

}



MainWindow::~MainWindow()
{
    waterSerialPort->close();
    granSerialPort->close();

    delete waterTimer;
    delete granTimer;
    delete waterSerialPort;
    delete granSerialPort;

    delete ui;

}




