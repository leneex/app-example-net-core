# .NET

Example [.NET](https://dotnet.microsoft.com/) app. ASP.NET Core is a cross-platform framework from Microsoft for building web apps and APIs in C#.

## Deploy settings

| Field | Value |
| --- | --- |
| Build | Railpack |
| Project directory | `/` |
| Install command | leave empty |
| Build command | leave empty |
| Start command | leave empty |
| Application port | `8080` |
| Health check path | `/` |

## <a name="dev"></a>Run locally

```bash
# run in development mode with watch
dotnet watch

# build and run the app
dotnet run
```

Requires .NET SDK 10 or later.
