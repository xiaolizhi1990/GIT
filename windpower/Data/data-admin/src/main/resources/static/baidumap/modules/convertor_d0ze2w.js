_jsload2&&_jsload2('convertor', 'z.extend(lc.prototype,{qQ:function(){for(var a=0,b=this.Pa.length;a<b;a++){var c=this.Pa[a];this[c.method].apply(this,c.arguments)}delete this.Pa},translate:function(a,b,c,e){b=b||1;c=c||5;if(10<a.length)e&&e({status:25});else{var f=B.Wc+"geoconv/v1/?coords=";z.Fb(a,function(a){f+=a.lng+","+a.lat+";"});f=f.replace(/;$/gi,"");f=f+"&from="+b+"&to="+c+"&ak="+qa;oa(f,function(a){if(0===a.status){var b=[];z.Fb(a.result,function(a){b.push(new B.Point(a.x,a.y))});delete a.result;a.points=b}e&&e(a)})}}}); ');