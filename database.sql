use InsanmarTec
go

create table dbo.Brands
(
    Id                   int identity
        constraint PK_Brands
            primary key,
    Name                 varchar(50)  not null,
    Description          varchar(150) not null,
    Category             varchar(50)  not null,
    IsActive             bit          not null,
    CreationTime         date         not null,
    LastModificationTime date
)
go

create unique index IX_Brands_Name
    on dbo.Brands (Name)
go

create table dbo.Customers
(
    Id                   int identity
        constraint PK_Customers
            primary key,
    FirstName            varchar(50)  not null,
    LastName             varchar(50)  not null,
    Address              varchar(150) not null,
    Phone                varchar(9)   not null,
    Email                varchar(50)  not null,
    Dni                  varchar(8)   not null,
    IsActive             bit          not null,
    CreationTime         date         not null,
    LastModificationTime date
)
go

create unique index IX_Customers_Email
    on dbo.Customers (Email)
go

create table dbo.Models
(
    Id                   int identity
        constraint PK_Models
            primary key,
    Name                 varchar(50) not null,
    IsActive             bit         not null,
    BrandId              int         not null
        constraint FK_Models_Brands_BrandId
            references dbo.Brands
            on delete cascade,
    CreationTime         date        not null,
    LastModificationTime date
)
go

create index IX_Models_BrandId
    on dbo.Models (BrandId)
go

create table dbo.PaymentMethods
(
    Id           int identity
        constraint PK_PaymentMethods
            primary key,
    Name         varchar(50) not null,
    IsActive     bit         not null,
    CreationTime date        not null
)
go

create table dbo.Qualities
(
    Id          int identity
        constraint PK_Qualities
            primary key,
    Name        varchar(50)  not null,
    Description varchar(150) not null
)
go

create table dbo.Products
(
    Id                   int identity (100000, 1)
        constraint PK_Products
            primary key,
    Name                 varchar(50)  not null,
    Description          varchar(150) not null,
    Price                money        not null,
    IsActive             bit          not null,
    ModelId              int          not null
        constraint FK_Products_Models_ModelId
            references dbo.Models
            on delete cascade,
    QualityId            int          not null
        constraint FK_Products_Qualities_QualityId
            references dbo.Qualities
            on delete cascade,
    CreationTime         date         not null,
    LastModificationTime date
)
go

create index IX_Products_ModelId
    on dbo.Products (ModelId)
go

create index IX_Products_QualityId
    on dbo.Products (QualityId)
go

create table dbo.Roles
(
    Id                   int identity
        constraint PK_Roles
            primary key,
    Name                 varchar(50)  not null,
    Description          varchar(150) not null,
    CreationTime         date         not null,
    LastModificationTime date
)
go

create unique index IX_Roles_Name
    on dbo.Roles (Name)
go

create table dbo.Sales
(
    Id                   int identity (100000, 1)
        constraint PK_Sales
            primary key,
    CustomerId           int  not null
        constraint FK_Sales_Customers_CustomerId
            references dbo.Customers
            on delete cascade,
    PaymentMethodId      int  not null
        constraint FK_Sales_PaymentMethods_PaymentMethodId
            references dbo.PaymentMethods
            on delete cascade,
    CreationTime         date not null,
    LastModificationTime date,
    IsDeleted            bit  not null,
    DeletionTime         date
)
go

create table dbo.ExitNotes
(
    Id                   int identity (100000, 1)
        constraint PK_ExitNotes
            primary key,
    SaleId               int  not null
        constraint FK_ExitNotes_Sales_SaleId
            references dbo.Sales
            on delete cascade,
    CreationTime         date not null,
    LastModificationTime date,
    IsDeleted            bit  not null,
    DeletionTime         date
)
go

create index IX_ExitNotes_SaleId
    on dbo.ExitNotes (SaleId)
go

create table dbo.SaleDetails
(
    Id                   int identity
        constraint PK_SaleDetails
            primary key,
    Quantity             int   not null,
    UnitPrice            money not null,
    SaleId               int   not null
        constraint FK_SaleDetails_Sales_SaleId
            references dbo.Sales
            on delete cascade,
    ProductId            int   not null
        constraint FK_SaleDetails_Products_ProductId
            references dbo.Products
            on delete cascade,
    CreationTime         date  not null,
    LastModificationTime date
)
go

create index IX_SaleDetails_ProductId
    on dbo.SaleDetails (ProductId)
go

create index IX_SaleDetails_SaleId
    on dbo.SaleDetails (SaleId)
go

create index IX_Sales_CustomerId
    on dbo.Sales (CustomerId)
go

create index IX_Sales_PaymentMethodId
    on dbo.Sales (PaymentMethodId)
go

create table dbo.StockMovements
(
    Id                   int identity
        constraint PK_StockMovements
            primary key,
    QuantityChange       int  not null,
    TransactionType      int  not null,
    ProductId            int  not null
        constraint FK_StockMovements_Products_ProductId
            references dbo.Products
            on delete cascade,
    CreationTime         date not null,
    LastModificationTime date
)
go

create index IX_StockMovements_ProductId
    on dbo.StockMovements (ProductId)
go

create table dbo.Suppliers
(
    Id                   int identity
        constraint PK_Suppliers
            primary key,
    Name                 varchar(50)  not null,
    Address              varchar(150) not null,
    Phone                varchar(9)   not null,
    Email                varchar(50)  not null,
    IsActive             bit          not null,
    CreationTime         date         not null,
    LastModificationTime date
)
go

create table dbo.PurchaseOrders
(
    Id                   int identity (100000, 1)
        constraint PK_PurchaseOrders
            primary key,
    Status               int  not null,
    SupplierId           int  not null
        constraint FK_PurchaseOrders_Suppliers_SupplierId
            references dbo.Suppliers
            on delete cascade,
    CreationTime         date not null,
    LastModificationTime date,
    IsDeleted            bit  not null,
    DeletionTime         date
)
go

create table dbo.PurchaseOrderDetails
(
    Id                   int identity
        constraint PK_PurchaseOrderDetails
            primary key,
    Quantity             int   not null,
    UnitPrice            money not null,
    PurchaseOrderId      int   not null
        constraint FK_PurchaseOrderDetails_PurchaseOrders_PurchaseOrderId
            references dbo.PurchaseOrders
            on delete cascade,
    ProductId            int   not null
        constraint FK_PurchaseOrderDetails_Products_ProductId
            references dbo.Products
            on delete cascade,
    CreationTime         date  not null,
    LastModificationTime date
)
go

create index IX_PurchaseOrderDetails_ProductId
    on dbo.PurchaseOrderDetails (ProductId)
go

create index IX_PurchaseOrderDetails_PurchaseOrderId
    on dbo.PurchaseOrderDetails (PurchaseOrderId)
go

create index IX_PurchaseOrders_SupplierId
    on dbo.PurchaseOrders (SupplierId)
go

create table dbo.Purchases
(
    Id                   int identity (100000, 1)
        constraint PK_Purchases
            primary key,
    Status               int  not null,
    PurchaseOrderId      int  not null
        constraint FK_Purchases_PurchaseOrders_PurchaseOrderId
            references dbo.PurchaseOrders
            on delete cascade,
    CreationTime         date not null,
    LastModificationTime date,
    IsDeleted            bit  not null,
    DeletionTime         date
)
go

create table dbo.EntryNotes
(
    Id           int identity (100000, 1)
        constraint PK_EntryNotes
            primary key,
    PurchaseId   int  not null
        constraint FK_EntryNotes_Purchases_PurchaseId
            references dbo.Purchases
            on delete cascade,
    CreationTime date not null
)
go

create index IX_EntryNotes_PurchaseId
    on dbo.EntryNotes (PurchaseId)
go

create index IX_Purchases_PurchaseOrderId
    on dbo.Purchases (PurchaseOrderId)
go

create table dbo.Users
(
    Id                   int identity
        constraint PK_Users
            primary key,
    FirstName            varchar(50)  not null,
    LastName             varchar(50)  not null,
    Username             varchar(50)  not null,
    Email                varchar(50)  not null,
    Password             varchar(100) not null,
    IsActive             bit          not null,
    CreationTime         date         not null,
    LastModificationTime date
)
go

create table dbo.RoleUser
(
    RolesId int not null
        constraint FK_RoleUser_Roles_RolesId
            references dbo.Roles
            on delete cascade,
    UsersId int not null
        constraint FK_RoleUser_Users_UsersId
            references dbo.Users
            on delete cascade,
    constraint PK_RoleUser
        primary key (RolesId, UsersId)
)
go

create index IX_RoleUser_UsersId
    on dbo.RoleUser (UsersId)
go

create unique index IX_Users_Email
    on dbo.Users (Email)
go

create unique index IX_Users_Username
    on dbo.Users (Username)
go
