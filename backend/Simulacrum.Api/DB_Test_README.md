1. Navigate to `/Simulacrum/Backend/`
2. Ensure that you have your .env filled out, assigning SUPABASE_URL and SUPABASE_KEY (place it in /Simulacrum/Simulacrum.Api/.env)
3. Execute `dotnet run --project Simulacrum.Api`
4. In a 2nd terminal instance, send a POST with CURL:
```bash
curl -X POST "http://localhost:5296/Test/send" \
-H "Content-Type: application/json" \
-d '{
"name": "Gotrek Gurnisson",
"description": "Wielder of a powerful Runic Axe",
"tags": ["Dwarf", "Slayer"]
}'
```

5. To retrieve the data, Send another `curl` request:
```bash
# By UUID
curl -X GET "http://localhost:5296/Test/<UUID>"
# Or by name
curl -X GET "http://localhost:5296/Test/name?name=<NAME>" # Use %20 if there's a space
```