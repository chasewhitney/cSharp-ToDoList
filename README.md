# ToDo List

Simple ToDo list. Can use SQL or a text file as the database by using
GlobalConfig.InitializeConnections(DatabaseType.Text);
or
GlobalConfig.InitializeConnections(DatabaseType.Sql);
in ToDoListUI/Program.cs

## Built With

C#, Dapper, SQL using Microsoft Visual Studio.

## Stored Procedures

CREATE PROCEDURE [dbo].[spTasks_GetAll]
AS
BEGIN
SET NOCOUNT ON;

    select *
    from dbo.Tasks
    where Completed = 0

END

CREATE PROCEDURE [dbo].[spTasks_Insert]
@Name nvarchar(500),
@id int = 0 output
AS
BEGIN
SET NOCOUNT ON;

    insert into dbo.Tasks (Name, Completed)
    values (@Name, 0);
    select @id = SCOPE_IDENTITY();

END

CREATE PROCEDURE [dbo].[spTasks_Update]
@id int,
@Name nvarchar(500),
@Completed bit
AS
BEGIN
SET NOCOUNT ON;

    update dbo.Tasks
    set Name = @Name, Completed = @Completed
    where id = @id;

END

CREATE PROCEDURE [dbo].[Tasks_Delete]
@id int
AS
BEGIN
SET NOCOUNT ON;

    delete from
    dbo.Tasks
    where id = @id;

END
