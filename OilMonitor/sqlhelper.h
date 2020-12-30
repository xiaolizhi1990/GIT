#ifndef SQLHELPER_H
#define SQLHELPER_H
#include <QString>
#include <QSqlDatabase>
#include <QSqlQuery>
#include <water.h>
#include <granule.h>
class SqlHelper
{
public:
    SqlHelper();
    void init();
     bool insertWaterPara(water &paras);
     bool insertGranPara(granule &paras);

     void initWater( QSqlDatabase &db);
     bool initGran(QSqlDatabase &db);

     void initWaterQuery(QSqlQuery &query);
     void initGranQuery(QSqlQuery &query);

     QSqlDatabase waterDB;
     QSqlDatabase granDB;
     QSqlQuery waterQuery;
    // QSqlQuery granQuery;
};

#endif // SQLHELPER_H
