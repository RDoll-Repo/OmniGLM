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
        "createdAt": ""
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
                "title": "Party"
            },
            {
                "id": "f0a27594-756d-4def-b552-6e2fff40066b",
                "title": "Platformer"
            },
            {
                "id": "2cfc3d16-93cd-414f-868a-af891107225d",
                "title": "Puzzle"
            }
        ]
    }
}
```

`200 OK - The search results`

### Fetch Genres
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
        "title": "Party"
    }
}
```

`200 OK - The fetched genre`