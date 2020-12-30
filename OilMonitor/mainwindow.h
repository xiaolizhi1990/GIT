#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QTimer>
#include <QtSerialPort/QSerialPort>
#include <sqlhelper.h>
namespace Ui {
class MainWindow;
}



class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();

    QString localConnStr;
    //水分
    QString waterCom;
    int waterRate;
    bool waterOpen;
    //颗粒度
    QString granularityCom;
    int granularityRate;
    bool granularityOpen;

    QTimer *waterTimer;
    QTimer *granTimer;

    QSerialPort *waterSerialPort;
    QSerialPort *granSerialPort;

    SqlHelper sqlHelper;



private slots:
    void waterSerialPort_write();
    void waterSerialPort_read();
    void granSerialPort_write();
    void granSerialPort_read();



private:
    Ui::MainWindow *ui;




};

#endif // MAINWINDOW_H
