/*
 Navicat Premium Data Transfer

 Source Server         : .
 Source Server Type    : SQL Server
 Source Server Version : 12004237
 Source Host           : .:1433
 Source Catalog        : OAtoU8DATA
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 12004237
 File Encoding         : 65001

 Date: 27/07/2018 11:48:00
*/


-- ----------------------------
-- Table structure for contrast
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[contrast]') AND type IN ('U'))
	DROP TABLE [dbo].[contrast]
GO

CREATE TABLE [dbo].[contrast] (
  [id] int IDENTITY(1,1) NOT NULL,
  [baoxiaoId] bigint NOT NULL,
  [yuzhiId] bigint NOT NULL,
  [l4] decimal(18,2) NULL,
  [l5] decimal(18,2) NULL,
  [l6] decimal(18,2) NULL,
  [l7] decimal(18,2) NULL,
  [l13] decimal(18,2) NULL
)
GO

ALTER TABLE [dbo].[contrast] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'自增id',
'SCHEMA', N'dbo',
'TABLE', N'contrast',
'COLUMN', N'id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'报销id',
'SCHEMA', N'dbo',
'TABLE', N'contrast',
'COLUMN', N'baoxiaoId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'预支id',
'SCHEMA', N'dbo',
'TABLE', N'contrast',
'COLUMN', N'yuzhiId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'冲账流量4',
'SCHEMA', N'dbo',
'TABLE', N'contrast',
'COLUMN', N'l4'
GO

EXEC sp_addextendedproperty
'MS_Description', N'冲账流量5',
'SCHEMA', N'dbo',
'TABLE', N'contrast',
'COLUMN', N'l5'
GO

EXEC sp_addextendedproperty
'MS_Description', N'冲账流量6',
'SCHEMA', N'dbo',
'TABLE', N'contrast',
'COLUMN', N'l6'
GO

EXEC sp_addextendedproperty
'MS_Description', N'冲账流量7',
'SCHEMA', N'dbo',
'TABLE', N'contrast',
'COLUMN', N'l7'
GO

EXEC sp_addextendedproperty
'MS_Description', N'冲账流量13',
'SCHEMA', N'dbo',
'TABLE', N'contrast',
'COLUMN', N'l13'
GO

EXEC sp_addextendedproperty
'MS_Description', N'冲账对照表',
'SCHEMA', N'dbo',
'TABLE', N'contrast'
GO


-- ----------------------------
-- Table structure for producehelp
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[producehelp]') AND type IN ('U'))
	DROP TABLE [dbo].[producehelp]
GO

CREATE TABLE [dbo].[producehelp] (
  [id] int IDENTITY(1,1) NOT NULL,
  [col_id] bigint NOT NULL,
  [isShow] int NOT NULL,
  [intoForm] bigint NOT NULL
)
GO

ALTER TABLE [dbo].[producehelp] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'自增id',
'SCHEMA', N'dbo',
'TABLE', N'producehelp',
'COLUMN', N'id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'单据id，对应v3x col-summary',
'SCHEMA', N'dbo',
'TABLE', N'producehelp',
'COLUMN', N'col_id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否执行成功存储过程',
'SCHEMA', N'dbo',
'TABLE', N'producehelp',
'COLUMN', N'isShow'
GO

EXEC sp_addextendedproperty
'MS_Description', N'目标模板id',
'SCHEMA', N'dbo',
'TABLE', N'producehelp',
'COLUMN', N'intoForm'
GO

EXEC sp_addextendedproperty
'MS_Description', N'生成单据存储过程临时表',
'SCHEMA', N'dbo',
'TABLE', N'producehelp'
GO


-- ----------------------------
-- Table structure for RecordTable
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[RecordTable]') AND type IN ('U'))
	DROP TABLE [dbo].[RecordTable]
GO

CREATE TABLE [dbo].[RecordTable] (
  [id] int IDENTITY(1,1) NOT NULL,
  [Pid] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [IsIntoBook] int NULL,
  [IsIntoCloseBill] int NULL,
  [IsIntoAccvouch] int NULL,
  [PayingBank] nvarchar(max) COLLATE Chinese_PRC_CI_AS NULL,
  [voucher] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [updateTime] datetime NULL,
  [updateTime2] datetime NULL,
  [updateTime3] datetime NULL,
  [ip] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [ip2] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [ip3] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [Bid] int NULL,
  [contents] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [voucherno] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [piaojuId] int NULL,
  [liushuihao] bigint NULL,
  [type] int NULL,
  [amountMoney] decimal(18,2) NULL,
  [chunabianhao] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [pingzhenhao] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [danjubianhao] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [userName] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL,
  [l4] decimal(18,2) NULL,
  [l5] decimal(18,2) NULL,
  [l6] decimal(18,2) NULL,
  [l7] decimal(18,2) NULL,
  [l13] decimal(18,2) NULL
)
GO

ALTER TABLE [dbo].[RecordTable] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'oa的发票单号',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'Pid'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否插入到U8AcctBook表',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'IsIntoBook'
GO

EXEC sp_addextendedproperty
'MS_Description', N'CloseBill是否插入（生单）',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'IsIntoCloseBill'
GO

EXEC sp_addextendedproperty
'MS_Description', N'Accvouch是否插入（制单）',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'IsIntoAccvouch'
GO

EXEC sp_addextendedproperty
'MS_Description', N'日记账时间',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'updateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'生单时间',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'updateTime2'
GO

EXEC sp_addextendedproperty
'MS_Description', N'制单时间',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'updateTime3'
GO

EXEC sp_addextendedproperty
'MS_Description', N'插入Acctbook表的电脑的ip地址(现在改为日记账录入者姓名)',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'ip'
GO

EXEC sp_addextendedproperty
'MS_Description', N'插入CloseBill表的电脑的ip地址(生单录入者姓名)',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'ip2'
GO

EXEC sp_addextendedproperty
'MS_Description', N'插入Accvouch表的电脑的ip地址(制单者姓名)',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'ip3'
GO

EXEC sp_addextendedproperty
'MS_Description', N'插入AcctBook表后的自增id(日记账id)',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'Bid'
GO

EXEC sp_addextendedproperty
'MS_Description', N'付款账号Id',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'contents'
GO

EXEC sp_addextendedproperty
'MS_Description', N'凭证号',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'voucherno'
GO

EXEC sp_addextendedproperty
'MS_Description', N'凭据id，每个纸质单一个凭据',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'piaojuId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'流水号',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'liushuihao'
GO

EXEC sp_addextendedproperty
'MS_Description', N'单据类型（1预支单，2，费用报销单，3，付款审批，4,。差旅费报销单）',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'type'
GO

EXEC sp_addextendedproperty
'MS_Description', N'金额',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'amountMoney'
GO

EXEC sp_addextendedproperty
'MS_Description', N'出纳编号',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'chunabianhao'
GO

EXEC sp_addextendedproperty
'MS_Description', N'凭证编号',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'pingzhenhao'
GO

EXEC sp_addextendedproperty
'MS_Description', N'单据编号',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'danjubianhao'
GO

EXEC sp_addextendedproperty
'MS_Description', N'发起人',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'userName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'流量4金额',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'l4'
GO

EXEC sp_addextendedproperty
'MS_Description', N'流量5金额',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'l5'
GO

EXEC sp_addextendedproperty
'MS_Description', N'流量6金额',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'l6'
GO

EXEC sp_addextendedproperty
'MS_Description', N'流量7金额',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'l7'
GO

EXEC sp_addextendedproperty
'MS_Description', N'流量13金额',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable',
'COLUMN', N'l13'
GO

EXEC sp_addextendedproperty
'MS_Description', N'OAU8信息导入对照表',
'SCHEMA', N'dbo',
'TABLE', N'RecordTable'
GO


-- ----------------------------
-- Table structure for triggerSummary
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[triggerSummary]') AND type IN ('U'))
	DROP TABLE [dbo].[triggerSummary]
GO

CREATE TABLE [dbo].[triggerSummary] (
  [id] bigint IDENTITY(1,1) NOT NULL,
  [state] int NULL,
  [subject] nvarchar(255) COLLATE Chinese_PRC_CI_AS NULL,
  [create_date] datetime NULL,
  [start_date] datetime NULL,
  [finish_date] datetime NULL,
  [templete_id] bigint NULL,
  [start_member_id] bigint NULL
)
GO

ALTER TABLE [dbo].[triggerSummary] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for userInfo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[userInfo]') AND type IN ('U'))
	DROP TABLE [dbo].[userInfo]
GO

CREATE TABLE [dbo].[userInfo] (
  [id] int IDENTITY(1,1) NOT NULL,
  [name] nvarchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [password] nvarchar(50) COLLATE Chinese_PRC_CI_AS NOT NULL,
  [start] bit NOT NULL,
  [type] int NOT NULL,
  [phnoe] nvarchar(50) COLLATE Chinese_PRC_CI_AS NULL
)
GO

ALTER TABLE [dbo].[userInfo] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'自增id',
'SCHEMA', N'dbo',
'TABLE', N'userInfo',
'COLUMN', N'id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'姓名',
'SCHEMA', N'dbo',
'TABLE', N'userInfo',
'COLUMN', N'name'
GO

EXEC sp_addextendedproperty
'MS_Description', N'密码（明文方便管理员后台修改）',
'SCHEMA', N'dbo',
'TABLE', N'userInfo',
'COLUMN', N'password'
GO

EXEC sp_addextendedproperty
'MS_Description', N'状态（1：使用中，0：禁用）',
'SCHEMA', N'dbo',
'TABLE', N'userInfo',
'COLUMN', N'start'
GO

EXEC sp_addextendedproperty
'MS_Description', N'类型0：出纳，1：财务会计，2：普通员工',
'SCHEMA', N'dbo',
'TABLE', N'userInfo',
'COLUMN', N'type'
GO

EXEC sp_addextendedproperty
'MS_Description', N'电话',
'SCHEMA', N'dbo',
'TABLE', N'userInfo',
'COLUMN', N'phnoe'
GO

EXEC sp_addextendedproperty
'MS_Description', N'用户表',
'SCHEMA', N'dbo',
'TABLE', N'userInfo'
GO


-- ----------------------------
-- Primary Key structure for table contrast
-- ----------------------------
ALTER TABLE [dbo].[contrast] ADD CONSTRAINT [PK_contrast] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table producehelp
-- ----------------------------
ALTER TABLE [dbo].[producehelp] ADD CONSTRAINT [PK_producehelp] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table RecordTable
-- ----------------------------
ALTER TABLE [dbo].[RecordTable] ADD CONSTRAINT [PK_RecordTable] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table triggerSummary
-- ----------------------------
ALTER TABLE [dbo].[triggerSummary] ADD CONSTRAINT [PK_triggerSummary] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table userInfo
-- ----------------------------
ALTER TABLE [dbo].[userInfo] ADD CONSTRAINT [PK_userInfo] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

