CREATE TABLE Dummy (); /*This needs to be here for some magical reason. There is some symbol in this
file which sqlite cannot handle.*/

CREATE TABLE Tasks (
    /*Integers are ok for this project, and sqlite does not
    have great support for guid*/
    TaskId INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT
    ,TaskDescription TEXT
    ,CreatedDate TEXT
    ,TargetDate TEXT
    ,CompletedStatus INTEGER
    ,UserFK INTEGER
    ,FOREIGN KEY (UserFK) REFERENCES Users(UserId)
);

CREATE TABLE Users (
    TaskId INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT
    ,UserName TEXT(255)
);