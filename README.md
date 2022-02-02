# Technical Challenge (Web Api - JWT Authentication)

This project implement a simple e-learning tracking reporting API using .NET Core and SQL ASP.NET Core web API application using JWT auth.

## Requirements

1. Dotnet 6.0

    https://dotnet.microsoft.com/en-us/download/dotnet/6.0

2. SQL Server
    For database management purpose
    https://www.microsoft.com/en-ca/sql-server/sql-server-downloads

#. Postman
    For testing the api
    https://www.postman.com/

## DATA MODEL
We'll support a simple online course db model list in our implementation. Please create
following tables with their columns in the database
    Course
        • Id: string (GUID)
        • Name: string(250 chars)
    Lesson
        • Id: string(GUID)
        • Name: string(250 chars)
        • lessonUrl: string(355 chars)
        • courseId: Foreign key to course.id
    TrackingLog
        • Id: string
        • courseId: Foreign key to course.id
        • lessonId: Foreign key to lesson.id
        • userId: Foreign key to user.id
        • score: number from 0 to 100
    User
        • Id: string
        • fullName: string


## Usage

The app is configured to run with dotnet.
 You can launch the demo by the following command.

```bash
dotnet run
```
you can also open the project with your favorit text editor or with visual studio

The project should be redirected to your localhost with port: 44300

Make some request with post request to log with current id

```
curl --location --request POST 'https://localhost:44300/api/UserAuthentication/login' \
--header 'Authorization: Basic PEJhc2ljIEF1dGggVXNlcm5hbWU+OjxCYXNpYyBBdXRoIFBhc3N3b3JkPg==' \
--header 'Content-Type: application/json' \
--data-raw '{
  "id": "userId"
}'
```
Make some request with get request to return response with current id

```
curl --location --request GET 'https://localhost:44300/api/Lesson/{id}' \
--header 'Authorization: Bearer %%TOKEN%%'
```

**NOTE:** You can also move the folders around to consolidate the solution as one ASP.NET Core web app using the SPA service.
