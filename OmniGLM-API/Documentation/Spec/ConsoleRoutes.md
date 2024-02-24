# Console Routes

This section of the spec outlines controller routes related to consoles as a resoure.

[Back to Main](APISpec.md)

## Endpoints


### Create Console 
---
`POST /consoles`

**Request Body:**
```json
{
    "meta": {},
    "data": {
        "title": "Sega Genesis"
    }
}
```

**Response Body:**
```json
201 Created - The created console
{
    "meta": {},
    "data": {
        "id": "8abf368b-34b4-4766-b3c2-1446e6d63586",
        "title": "Sega Genesis",
        "createdAt": "2024-02-08T10:58:35.330683Z",
        "updatedAt": null
    }
}
```


### Get Consoles (To be deprecated and replaced with search)
---
`GET /consoles`

**Request Body:** NONE

**Response Body:**
```json
200 OK - The search results
{
    "meta": {},
    "data": {
        "consoles": [
            {
                "id": "bd7859c9-7d60-430d-885b-996a9ce5335e",
                "title": "PS4",
                "createdAt": "2024-02-08T10:58:35.330683Z",
                "updatedAt": null
            },
            {
                "id": "f0a27594-756d-4def-b552-6e2fff40066b",
                "title": "Sega Genesis",
                "createdAt": "2024-02-08T10:58:35.330683Z",
                "updatedAt": null
            },
            {
                "id": "2cfc3d16-93cd-414f-868a-af891107225d",
                "title": "Nintendo Switch",
                "createdAt": "2024-02-08T10:58:35.330683Z",
                "updatedAt": null
            }
        ]
    }
}
```


### Fetch Console
---
`GET /consoles/{id}`

**Request Body:** NONE

**Response Body:**
```json
200 OK - The fetched console
{
    "meta": {},
    "data": {
        "id": "bd7859c9-7d60-430d-885b-996a9ce5335e",
        "title": "Playstation 4",
        "createdAt": "2024-02-08T10:58:35.330683Z",
        "updatedAt": null
    }
}
```