# cloud-app

Technical: + Frontend: Reactjs, TypeScript + Backend: ASP.Net core 3.1 + Database: SQL Server 2018
Tools: + Visual Studio 2022 + Visual Studio Code + SQL Server 2018 + Git

Target:

- Log: serial log
- Realtime (Chat + push Notification): Firebase
- Caching: Redis

Config and run project Api:

- Clone source at: https://github.com/vuongnguyen99/cloud-app.git
- Open cloudapp-api.sln
- Set start up project data
- Change ConnectionString in appsettings.json in cloudapp-data.sln
- Open Tools --> Nuget Package Manager --> Package Manager Console in Visual Studio
- Run Update-database and Enter.
- After migrate database successful, set Startup Project is cloudapp-api
- Change database connection in appsettings.json in cloudapp-api project.
