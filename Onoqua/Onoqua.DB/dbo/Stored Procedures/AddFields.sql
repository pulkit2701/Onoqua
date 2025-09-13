CREATE PROCEDURE AddFields 
	@fieldName varchar(100),
	@fieldType	varchar(10),
	@groupName varchar(100)
AS
BEGIN
Insert into Fields (FieldType, FieldName) values (@fieldType, @fieldName)
Declare @fieldId int
select @fieldId=fieldid from fields where FieldName=@fieldName
if(not exists(select GroupName from groups where GroupName=@groupName))
Begin
	insert into Groups (GroupName) values (@groupName)
End
Declare @groupId int
select @groupId=groupid from Groups where GroupName=@groupName
insert into GroupFields (GroupID, FieldID) values (@groupId, @fieldId)
END
