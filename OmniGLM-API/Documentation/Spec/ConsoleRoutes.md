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