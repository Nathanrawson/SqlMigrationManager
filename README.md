SQL Migration Manager

Features:
- Stored procedure script, this allows for keeping stored procedures within your main repo and if Added as part of a pipiline or manually run before release it will update all changed or new store procedures. This requires writing your stored procedures with "create or alter procedure"

Future features:
- General migration script handling, by setting a directory with all migration scripts we will ad dthis to run in program so we no longer need to manually run migration scripts
- Table handling, ideally we will have script than can identify table changes and make those table changes vs having to run a script to add/remove columns manually. 
