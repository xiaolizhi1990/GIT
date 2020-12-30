#ifndef GRANULE_H
#define GRANULE_H
#include <QString>

class granule
{
public:
    granule();
     QString   TimeDate;

     QString   ISO4um;
     QString   ISO6um;
     QString   ISO14um;
     QString   ISO21um;

     QString   SAE4um;
     QString   SAE6um;
     QString   SAE14um;
     QString   SAE21um;

     QString   NAS;
     QString   GOST;
     QString   Conc4um;
     QString   Conc6um;

     QString   Conc14um;
     QString   Conc21um;
     QString   FIndex;
     QString   MTime;

};

#endif // GRANULE_H
