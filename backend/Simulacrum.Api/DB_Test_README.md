# Developer DB Testing Guide
## Prerequisites
1. Navigate to `/Simulacrum/Backend/`
2. Ensure that you have your .env filled out, assigning SUPABASE_URL and SUPABASE_KEY (place it in Simulacrum.Api/.env)
3. Execute `dotnet run --project Simulacrum.Api`

## Option A: Test with Curl in a Bash Terminal
1. In a 2nd terminal instance, send a POST with CURL:
```bash
curl -X POST "http://localhost:5296/Test/send" \
-H "Content-Type: application/json" \
-d '{
"name": "Gotrek Gurnisson",
"description": "Wielder of a powerful Runic Axe",
"tags": ["Dwarf", "Slayer"]
}'
```

2. To retrieve the data, Send another `curl` request:
```bash
# By UUID
curl -X GET "http://localhost:5296/Test/<UUID>"
# Or by name
curl -X GET "http://localhost:5296/Test/name?name=<NAME>" # Use %20 if there's a space
```

3. Go to Supabase's table editor to inspect live data within the database.

## Option B: Test Interactively with Swagger UI
1. Open http://localhost:5296/swagger in your browser
2. Try out `POST /Test/send` to make an object. Enter the following JSON in the request body
```json
{
"name": "Gotrek Gurnisson",
"description": "Wielder of a powerful Runic Axe",
"tags": ["Dwarf", "Slayer"]
}
```
3. Click Execute to send the request. Inspect the HTTP response code and response body. 
4. Repeat with other endpoints, such as `GET /Test/{id}` or `GET /Test/name`, to test retrieval
5. Go to Supabase's table editor to inspect live data within the database.

