# Genre Routes

This section of the spec outlines controller routes related to genres as a resoure.


## Endpoints

### Create Genre 
---
```
POST /genres
```

**Request Body:**
```json
{
    "meta": {},
    "data": {
        "title": "Fighting"
    }
}
```

**Response Body:**
```json
{
    "meta": {},
    "data": {
        "id": "8abf368b-34b4-4766-b3c2-1446e6d63586",
        "title": "Fighting",
        "createdAt": "2024-02-08T10:58:35.330683Z",
        "updatedAt": null
    }
}
```

`201 Created - The created genre`

### Get Genres (To be deprecated and replaced with search)
---
```
GET /genres
```

**Request Body:** NONE

**Response Body:**
```json
{
    "meta": {},
    "data": {
        "genres": [
            {
                "id": "bd7859c9-7d60-430d-885b-996a9ce5335e",
                "title": "Party",
                "createdAt": "2024-02-08T10:58:35.330683Z",
                "updatedAt": null
            },
            {
                "id": "f0a27594-756d-4def-b552-6e2fff40066b",
                "title": "Platformer",
                "createdAt": "2024-02-08T10:58:35.330683Z",
                "updatedAt": null
            },
            {
                "id": "2cfc3d16-93cd-414f-868a-af891107225d",
                "title": "Puzzle",
                "createdAt": "2024-02-08T10:58:35.330683Z",
                "updatedAt": null
            }
        ]
    }
}
```

`200 OK - The search results`

### Fetch Genre
---
```
GET /genres/{id}
```

**Request Body:** NONE

**Response Body:**
```json
{
    "meta": {},
    "data": {
        "id": "bd7859c9-7d60-430d-885b-996a9ce5335e",
        "title": "Party",
        "createdAt": "2024-02-08T10:58:35.330683Z",
        "updatedAt": null
    }
}
```

`200 OK - The fetched genre`

### Update Genre
---
```
PUT /genres/{id}
```

**Request Body:** 
```json
{
    "meta": {},
    "data": {
        "title": "Character Action",
        "createdAt": "2024-02-08T10:58:35.330683Z"
    }
}
```

**Response Body:**
```json
{
    "meta": {},
    "data": {
        "id": "bd7859c9-7d60-430d-885b-996a9ce5335e",
        "title": "Character Action",
        "createdAt": "2024-02-08T10:58:35.330683Z",
        "updatedAt": "2024-03-09T10:58:35.330683Z"
    }
}
```

`200 OK - The updated genre`

### Delete Genre
---
```
DELETE /genres/{id}
```

**Request Body:** NONE

**Response Body:** NONE

`204 No Content - The genre was deleted`