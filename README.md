# SplashOrders
1. Edit appsettings.json for the "Database" field
2. Build the database via the Package Manager Console (PMC), ensuring that:
	a. Startup project is SplashOrders.Api
	b. Default project is SplashOrders.Domain
	c. Run command: "Update-Database -context DataContext"
3.The API URL for placing an order should be: https://<server>/api/SplashOrders/PlaceOrder, e.g., https://localhost:7171/api/SplashOrders/PlaceOrder

Example input data is:

{
  "id": 0,
  "customer": {
    "id": 0,
    "firstName": "Anthony",
    "lastName": "Odusanya",
    "email": "aaodusanya@outlook.com",
    "phone": "07733265963"
  },
  "products": [
    {
      "id": 0,
      "name": "Baked Beans",
      "description": "Baked beans (generic)",
      "cost": 0
    },
    {
      "id": 0,
      "name": "Malt Bread",
      "description": "In-store bakery",
      "cost": 0
    }
  ]
}
