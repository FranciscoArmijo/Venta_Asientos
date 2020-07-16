insert into PERFILESFranciscoArmijo(Rut, Nombre, ApPat, ApMat, Clave, NIVEL) values ('13506481-5', 'Ricardo', 'Tapia', 'Coronado', 'RTC13506481-5', 1);
DELETE FROM PERFILESFranciscoArmijo WHERE NOmbre = 'Ricardo';

select * from PERFILESFranciscoArmijo where Clave = 'RTC13506481-5' and ApPat like '%Ta%';