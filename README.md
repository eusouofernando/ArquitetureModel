# Sita Company
- 1) Download and install CouchBase on https://www.couchbase.com/downloads
- 2) Configure a bucket with name "sitadb"
- 3) Configure a user for bucket with name "sitadb". Security -> Add User
  ---- Name = "sitadb"
  ---- Full Name = "sitadb"
  ---- Password = 
  ---- ConfirmPassWord = 
  Set Role in sitadb as Application Access
- 4) Run script in couchbase query -> CREATE PRIMARY INDEX `sitadb_index` ON `sitadb` USING GSI;

- 5) Run WebProject in Visual Studio. There are two pages in the project
  5.A) Upload Page. This page should be use to upload xml file 
  5.B) List Parcels. Simple table to list xml data loaded by upload.
