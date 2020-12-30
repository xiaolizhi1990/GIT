#include "sqlhelper.h"
#include <QSqlDatabase>
#include <water.h>
#include <QDateTime>
#include <granule.h>
#include <QVariant>
#include <QDebug>
#include <QSqlError>
SqlHelper::SqlHelper()
{


}

void SqlHelper::initWater(QSqlDatabase &db)
{

    db=QSqlDatabase::addDatabase("QMYSQL");
    db.setHostName("localhost");
    db.setDatabaseName("shaft");
    db.setUserName("root");
    db.setPassword("root");
    db.open();
}

bool SqlHelper::initGran(QSqlDatabase &db)
{
    db=QSqlDatabase::addDatabase("QMYSQL");
    db.setHostName("localhost");
    db.setDatabaseName("shaft");
    db.setUserName("root");
    db.setPassword("root");
    return db.open();
}

void  SqlHelper::initWaterQuery(QSqlQuery &query)
{



}
void SqlHelper::initGranQuery(QSqlQuery &query)
{

}

bool SqlHelper::insertWaterPara(water &paras)
{
    QSqlQuery  waterQuery(waterQuery);
    waterQuery.prepare("insert into waterMonitor values(:TimeDate,:T,:P,:P40,:C,:C40,:RH,:RH20,:TMean,:PCBT,:RULT,:RULLG,:RUL,:APP40,:APC40,:AP,:fB,:OAge,:insertTime)");
    waterQuery.bindValue(":TimeDate",paras.TimeDate);
    waterQuery.bindValue(":T",paras.T);
    waterQuery.bindValue(":P",paras.P);
    waterQuery.bindValue(":P40",paras.P40);
    waterQuery.bindValue(":C",paras.C);
    waterQuery.bindValue(":C40",paras.C40);
    waterQuery.bindValue(":RH",paras.RH);
    waterQuery.bindValue(":RH20",paras.RH20);
    waterQuery.bindValue(":TMean",paras.TMean);
    waterQuery.bindValue(":PCBT",paras.PCBT);
    waterQuery.bindValue(":RULT",paras.RULT);
    waterQuery.bindValue(":RULLG",paras.RULLG);
    waterQuery.bindValue(":RUL",paras.RUL);
    waterQuery.bindValue(":APP40",paras.APP40);
    waterQuery.bindValue(":APC40",paras.APC40);
    waterQuery.bindValue(":AP",paras.AP);
    waterQuery.bindValue(":fB",paras.fB);
    QDateTime time=QDateTime::currentDateTime();
    QString str=time.toString("yyyy-MM-dd hh:mm::ss");
    waterQuery.bindValue(":insertTime",str);
    return waterQuery.exec();
}

bool SqlHelper::insertGranPara(granule &paras)
{
    QSqlQuery  granQuery(granDB);
    granQuery.prepare("insert into granMonitor values(:TimeDate,:ISO4um,:ISO6um,:ISO14um,:ISO21um,:SAE4um,:SAE6um,:SAE14um,:SAE21um,:NAS,:GOST,:Conc4um,:Conc6um,:Conc14um,:Conc21um,:FIndex,:MTime,:insertTime)");

    granQuery.bindValue(":TimeDate",paras.TimeDate);

    granQuery.bindValue(":ISO4um",paras.ISO4um);
    granQuery.bindValue(":ISO6um",paras.ISO6um);
    granQuery.bindValue(":ISO14um",paras.ISO14um);
    granQuery.bindValue(":ISO21um",paras.ISO21um);

    granQuery.bindValue(":SAE4um",paras.SAE4um);
    granQuery.bindValue(":SAE6um",paras.SAE6um);
    granQuery.bindValue(":SAE14um",paras.SAE14um);
    granQuery.bindValue(":SAE21um",paras.SAE21um);

    granQuery.bindValue(":NAS",paras.NAS);
    granQuery.bindValue(":GOST",paras.GOST);
    granQuery.bindValue(":Conc4um",paras.Conc4um);
    granQuery.bindValue(":Conc6um",paras.Conc6um);

    granQuery.bindValue(":Conc14um",paras.Conc14um);
    granQuery.bindValue(":Conc21um",paras.Conc21um);
    granQuery.bindValue(":FIndex",paras.FIndex);
    granQuery.bindValue(":MTime",paras.MTime);
    QDateTime time=QDateTime::currentDateTime();
    QString str=time.toString("yyyy-MM-dd hh:mm::ss");
    granQuery.bindValue(":insertTime",str);
    bool result= granQuery.exec();
    return result;

}





