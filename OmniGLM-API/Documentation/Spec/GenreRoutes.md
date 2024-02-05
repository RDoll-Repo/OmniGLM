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
    "meta": {
        "count": 3
    },
    "data": {
        "id": "8abf368b-34b4-4766-b3c2-1446e6d63586",
        "title": "Fighting"
    }
}
```

`201 Created - The created genre`
