# SecretSantaBack
### A self-hosted Secret Santa web application. Create groups, draw names, and exchange gift ideas with friends this winter. This is the backend part of the application. Look for the client following this URL.

## Configuration

The application reads its database connection string from a `.env` file, which is not stored in the repository. Before running the app, create a file named `.env` in the `SecretSantaBack.WebAPI/` folder with the following content:

```env
ConnectionStrings__Default=Server=<server>;Database=<database>;User Id=<user>;Password=<password>;TrustServerCertificate=True;
```

Replace the placeholders in `<angle brackets>` with your own SQL Server details. For a local SQL Server instance with Windows authentication, you can use:

```env
ConnectionStrings__Default=Server=localhost;Database=SecretSantaDb;Trusted_Connection=True;TrustServerCertificate=True;
```

If the file or the `ConnectionStrings__Default` key is missing, the application stops at startup with the error `Connection string 'Default' is not configured.`
