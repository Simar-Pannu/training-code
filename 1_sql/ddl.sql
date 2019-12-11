use master;
go 

--create
create database Pizzabox;
GO

/* 
creates MDF - master data file. It saves it in a xml file.
        Ldf - log data file. It saves the log/changes that was made in database
        ndf - nonmaster data file. Replicate data files to keep data into smaller files. Actually stores the data.
        CIAS - case insensitive, acess sensitive 

*/

create schema [Order];
go

create SCHEMA Accounts;
go

CREATE TABLE [Order].[Order]
(
    OrderId int not null identity(1,2) primary key   -- why not use inline, not flexable
    ,UserId int not null FOREIGN key references [Account].[User].UserId
    ,StoreId int not null -- foreign key,
    ,TotalCost decimal (3,2)
    ,OrderDate DateTime2 (7) not null -- computed
    ,Active bit not null                     -- instead of bool
   -- ,constraint PK_Order_OrderOd primary key (OrderId)
   -- ,constraint FK_Order_UserId FOREIGN Key UserId regerences Acount.User.UserId
)
create table [Order].[OrderPizza](
   OrderPizzaId int not null identity(1,2)
    ,OrderId int not null identity(1,2)
    ,PizzaId int not null identity(1,2)
)

create table [Order].[Pizza](
   PizzaId int not null identity(1,2)-- primary key,
    ,Price decimal(2,2) not NULL
    ,SizeId int not null
    ,CrustId int not NULL
    ,Active bit not null      

   
)


---ALTER 
alter table [Order].[Order]
    add constraint PK_Order_OrderId primary key (OrderId);
alter table [Order].[Order]
    add constraint PK_OrderPizza_OrderPizzaId primary key (OrderPizzaId);
alter table [Order].[Order]
    add constraint PK_Pizza_PizzaId primary key (PizzaId);

alter table [Order].[OrderPizza]
    add constraint FK_OrderPizza_PizzaId foreign key (PizzaId) references [Order].[Order](PizzaId) 
      
alter table [Order].[OrderPizza]
    add constraint FK_OrderPizza_OrderId foreign key (OrderId) references [Order].[Pizza](OrderId) 



alter table [Order].[Order]
    ADD CONSTRAINT DF_ORDER_ACTIVE default (1) for Active;
alter table [Order].[Pizza]
    ADD CONSTRAINT DF_Pizza_ACTIVE default (1) for Active;

Alter table [Order].[Order]
    add constraint CK_Order_TotalCost check (TotalCost < 500); -- possible should not do it

Alter table [Order].[Order]
    add constraint CK_Order_OrderDate check (OrderDate > '2019-11-11'); -- checked possible should not do it

Alter table [Order].[Order]
    drop constraint CK_Order_OrderDate; 

Alter table [Order].[Order]
    add TipAmount decimal(2,2) null; 
Alter table [Order].[Order]
    drop column TopAmount;

-- drop

drop table [Order].[OrderPizza]


-- truncate
truncate table [Order].[OrderPizza]
/*
Squence process of generating next value on set of rules
idenity - is a squence that lets you autoincrment in T-sql specifically
    session squence - autoicrement aslong the database is live
    database squence  - autoincreaments untill the end of the database lifetime.
    Define primary key first
    Define foriegn key can be later

Decimanl - number before point and number before point
Numeric - fidelty number (total amount of digits) and number fater point
there is not maximum

if more of something to do a thing then 3NF

*/