create table dbo.Drafts
(
	DraftId int identity primary key,
	Player1Id int not null foreign key references dbo.Players(PlayerId),
	Player2Id int not null foreign key references dbo.Players(PlayerId),
	Player3Id int not null foreign key references dbo.Players(PlayerId),
	Player4Id int not null foreign key references dbo.Players(PlayerId),
	Player5Id int not null foreign key references dbo.Players(PlayerId),
	Player6Id int foreign key references dbo.Players(PlayerId),
	Player7Id int foreign key references dbo.Players(PlayerId),
	Player8Id int foreign key references dbo.Players(PlayerId),
	Set1Id int not null foreign key references dbo.MagicSets(SetId),
	Set2Id int not null foreign key references dbo.MagicSets(SetId),
	Set3Id int not null foreign key references dbo.MagicSets(SetId),
	WinnerId int foreign key references dbo.Players(PlayerId)
)

insert into dbo.MagicSets values
(
	'Theros',
	'Theros'
)

insert into dbo.MagicSets values
(
	'Born of the Gods',
	'Theros'
)

insert into dbo.MagicSets values
(
	'Journey Into Nyx',
	'Theros'
)

insert into dbo.Drafts values
(
	1,
	2,
	3,
	4,
	5,
	6,
	7,
	8,
	1,
	2,
	3,
	1
)

select * from dbo.Players
select * from dbo.Drafts
select * from dbo.MagicSets

alter table dbo.MagicSets
add SetAbbreviation varchar(3) not null default('XXX')

update dbo.MagicSets
set SetAbbreviation = 'JOU'
where SetId = 3

alter table dbo.Drafts
add DraftDate datetime not null default(getdate())

alter table dbo.Players
add IsActive bit not null default(1)


update dbo.Players
set IsActive = 1
where PlayerId = 1

create table dbo.Announcements
(
	AnnouncementId int identity primary key,
	Title varchar(50) not null,
	Content varchar(MAX) not null,
	CreatedById int not null foreign key references dbo.Players(PlayerId)
)

alter table dbo.Announcements
add CreatedDate datetime not null

insert into dbo.Announcements
values
(
	'Second Test',
	'asdfhaspodfhapsoidhf apsoidhf apsiodhfapsoidhf asdpiofhasdioa sdiohasdoi af;okf sa;lf af a;sdnfa;sldkfhaspoi apos daposid fhpaosidhf aposidhf paosidhf paosidhf paoisdhf apiosdhfapiosdfhapisodhfp iaosdhfpoaishdfg;aoisdhfpoaisdfhp asdhf paiosdfh',
	2,
	getdate()
)

select * from dbo.Players

alter table dbo.Players
add Phone varchar(10) not null default('0000000000')

update dbo.Players
set Phone = '7327789673'
where PlayerId = 3