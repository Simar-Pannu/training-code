use master;
go 


drop database PizzaBoxDb
drop database Pizzabox

--create
create database PizzaBoxDb;
GO

use PizzaboxDb;
go


/* 
creates MDF - master data file. It saves it in a xml file.
        Ldf - log data file. It saves the log/changes that was made in database
        ndf - nonmaster data file. Replicate data files to keep data into smaller files. Actually stores the data.
        CIAS - case insensitive, acess sensitive 

*/

create schema [Order];
go


create Schema [Location];
GO

create schema [Address];
go

create schema [User];
GO

create schema [Pizza];
Go




--User

CREATE TABLE [User].[User]
(
    UserId int not null Identity(1,1)   -- why not use inline, not flexable
    ,FirstName nVarChar(40) not null
    ,LastName nVarChar(40) not NULL
    ,Manager bit not NULL
    ,AccountId int not null --FOREIGN KEY references [User].[Account].AccountId
    ,AddressId int not null --FOREIGN KEY references [Address].[Address].AddressId
)
CREATE TABLE [User].[Account]
(
    AccountId int not null Identity(1,1)
    ,Username nVarChar(40) not null
    ,UPassword nVarChar(40) not null 
)
CREATE TABLE [User].[UserOrder]
(
    UserOrderId int not null Identity(1,1)
    ,UserId int not null
    ,OrderId int not null
)


--Address

CREATE TABLE [Address].[Address]
(
    AddressId int not null Identity(1,1)
    ,[Address] nVarChar(40) not null
    ,[City] nVarChar(40) not null
    ,[State] nVarChar(40) not null 
    ,Country nVarChar(40) not null 
    ,ZipCode nVarChar(40) not null 
)



-- Location

CREATE TABLE [Location].[Location]
(
    LocationId int not null Identity(1,1)
    ,[Name] nVarChar(40) not null
    ,AddressId int not null -- FOREIGN KEY references [Address].[Address].AddressId
)
CREATE TABLE [Location].[LocationOrder]
(
    LocationOrderId int not null Identity(1,1)
    ,LocationId int not null
    ,OrderId int not null -- FOREIGN KEY references [Address].[Address].AddressId
)

--Order

CREATE TABLE [Order].[Order]
(
    OrderId int not null Identity(1,1)
    ,UserId int not null --FOREIGN key references [Account].[User].UserId
    ,LocationId int not null --FOREIGN key references [Location].[Location].StoreId -- foreign key,
    ,TotalCost decimal (3,2)
    ,OrderDate DateTime2 (7) not null -- computed
)
create table [Order].[OrderPizza](
    OrderPizzaId int not null Identity(1,2)
    ,OrderId int not null
    ,PizzaId int not null
)





--Pizza

create table [Pizza].[Pizza]
(
     PizzaId int not null Identity(1,1)
     ,[Name] nVarChar(40)
    ,Price decimal(2,2) not NULL
    ,SizeId int not null
    ,CrustId int not NULL
)
create table [Pizza].[PizzaIngredients]
(
    PizzaIngredientsId int not null Identity(1,1)
    ,PizzaId int not null
    ,IngredientId int not null
)
create table [Pizza].[Ingredient]
(
    IngredientId int not null Identity(1,1)
    ,[Name] nVarChar(40) not NULL
    ,Price decimal(2,2) not NULL
)
create table [Pizza].[Crust]
(
    CrustId int not null Identity(1,1)
    ,[Name] nVarChar(40) not NULL
    ,Price decimal(2,2) not NULL
)
create table [Pizza].[Size]
(
     SizeId int not null Identity(1,1)
    ,[Name] nVarChar(40) not NULL
    ,Price decimal(2,2) not NULL
)

--Primary Keys
--User

alter table [User].[User]
    add constraint PK_User_UserId primary key (UserId);
alter table [User].[Account]
    add constraint PK_Account_AccountId primary key (AccountId);
alter table [User].[UserOrder]
    add constraint PK_UserOrder_UserOrderId primary key (UserOrderId);
--Address
alter table [Address].[Address]
    add constraint PK_Address_AddressId primary key (AddressId);
--LOCATION
alter table [Location].[Location]
    add constraint PK_Location_LocationId primary key (LocationId);
alter table [Location].[LocationOrder]
    add constraint PK_LocationOrder_LocationOrderId primary key (LocationOrderId);
--ORDER
alter table [Order].[Order]
    add constraint PK_Location_LocationId primary key (OrderId);
alter table [Order].[OrderPizza]
    add constraint PK_OrderPizza_OrderPizzaId primary key (OrderPizzaId);
--Pizza
alter table [Pizza].[Pizza]
    add constraint PK_Pizza_PizzaId primary key (PizzaId);
alter table [Pizza].[PizzaIngredients]
    add constraint PK_PizzaIngredients_PizzaIngredientsId primary key (PizzaIngredientsId);
alter table [Pizza].[Ingredient]
    add constraint PK_Ingredient_IngredientId primary key (IngredientId);
alter table [Pizza].[Crust]
    add constraint PK_Crust_CrustId primary key (CrustId);
alter table [Pizza].[Size]
    add constraint PK_Size_SizeId primary key (SizeId);

--Foreign Key
--User
alter table [User].[User]
    add constraint FK_User_AccountId foreign key (AccountId) references [User].[Account](AccountId) 
alter table [User].[User]
    add constraint FK_User_AddressId foreign key (AddressId) references [Address].[Address](AddressId)
alter table [User].[UserOrder]
    add constraint FK_UserOrder_UserId foreign key (UserId) references [User].[User](UserId)
alter table [User].[UserOrder]
    add constraint FK_UserOrder_OrderId foreign key (OrderId) references [Order].[Order](OrderId)
--LOCATION
alter table [Location].[Location]
    add constraint FK_Location_AddressId foreign key (AddressId) references [Address].[Address](AddressId)
alter table [Location].[LocationOrder]
    add constraint FK_LocationOrder_LocationId foreign key (LocationId) references [Location].[Location](LocationId)
alter table [Location].[LocationOrder]
    add constraint FK_LocationOrder_OrderId foreign key (OrderId) references [Order].[Order](OrderId)

--ORDER
alter table [Order].[Order]
    add constraint FK_Order_UserId foreign key (UserId) references [User].[User](UserId) 
alter table [Order].[Order]
    add constraint FK_Order_LocationId foreign key (LocationId) references [Location].[Location](LocationId) 
alter table [Order].[OrderPizza]
    add constraint FK_OrderPizza_OrderId foreign key (OrderId) references [Order].[Order](OrderId) 
alter table [Order].[OrderPizza]
    add constraint FK_OrderPizza_PizzaId foreign key (PizzaId) references [Pizza].[Pizza](PizzaId) 
--Pizza
alter table [Pizza].[Pizza]
    add constraint FK_Pizza_SizeId foreign key (SizeId) references [Pizza].[Size](SizeId);
alter table [Pizza].[Pizza]
    add constraint FK_Pizza_CrustId foreign key (CrustId) references [Pizza].[Crust](CrustId);
alter table [Pizza].[PizzaIngredients]
    add constraint FK_PizzaIngredients_PizzaId foreign key (PizzaId) references [Pizza].[Pizza](PizzaId);  
alter table [Pizza].[PizzaIngredients]
    add constraint FK_PizzaIngredients_IngredientId foreign key (IngredientId) references [Pizza].[Ingredient](IngredientId); 
    