if not exists(select 1 from dbo.[Product])

begin
insert into dbo.[Product] (Name, Category)
values ('Bread', 'Food'),
('Banana', 'Food'),
('Water', 'Drink')
end