#-------------------------------------------------
#
# Project created by QtCreator 2017-03-20T20:13:39
#
#-------------------------------------------------
QT +=sql
QT+=serialport


#---QWT控件添加�?--------------
QWT_ROOT = C:\Qt5.3.2\qwt-6.1.0
include( $${QWT_ROOT}/qwtfunctions.pri )
INCLUDEPATH += $${QWT_ROOT}/src
DEPENDPATH  += $${QWT_ROOT}/src
%QWT_CONFIG  += QwtDll

contains(QWT_CONFIG, QwtFramework) {
    LIBS      += -F$${QWT_ROOT}/lib
}
else {

    LIBS      += -L$${QWT_ROOT}/lib
}
qwtAddLibrary(qwt)
contains(QWT_CONFIG, QwtOpenGL ) {

    QT += opengl
}
else {

    DEFINES += QWT_NO_OPENGL
}
contains(QWT_CONFIG, QwtSvg) {

    QT += svg
}
else {

    DEFINES += QWT_NO_SVG
}
win32 {
    contains(QWT_CONFIG, QwtDll) {
        DEFINES    += QT_DLL QWT_DLL
    }
}

#-------qwtk控件添加�? end------------




QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = oilMonitor
TEMPLATE = app


SOURCES += main.cpp\
        mainwindow.cpp \
    sqlhelper.cpp \
    water.cpp \
    granule.cpp

HEADERS  += mainwindow.h \
    sqlhelper.h \
    water.h \
    granule.h

FORMS    += mainwindow.ui

OTHER_FILES += \
    setting.txt

RESOURCES += \
    resouce.qrc
