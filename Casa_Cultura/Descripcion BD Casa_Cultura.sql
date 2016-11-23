select * from login;
SELECT * FROM login WHERE Usuario=Allan and password=SHA1(123) and Tipo_Usuario='Administrador';
SELECT * FROM login WHERE password=SHA1(123);