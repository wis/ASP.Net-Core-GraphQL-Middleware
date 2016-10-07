# ASP.Net-Core-GraphQL-Middleware
ASP.Net Core GraphQL Middleware

usage:
in your Startup.cs in the Configure() Method

```cs
app.UseGraphQL(new GraphQLOptions
{
    GraphQLPath = "/graphql" ,
    Schema = new Schema { Query = new StarWarsQuery() }
});

app.UseGraphiQL(new GraphiQLOptions()
{
    GraphiQLPath = "/graphiql"
});

```