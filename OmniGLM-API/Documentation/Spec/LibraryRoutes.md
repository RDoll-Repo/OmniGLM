# Library Routes

This section of the spec outlines controller routes related to the games in the library as a resoure.

[Back to Main](APISpec.md)

## Endpoints


### Create Game
---
```
POST /library
```

**Request Body:**
```json
{
    "meta": {},
    "data": {
        "title": "Baldur's Gate 3",
        "status": "Playing",
        "consoleId": "c4b6474a-a2c5-4e4c-bdd5-5b4a156863ec",
        "format": "Special",
        "genreId": "82a091f6-4dba-47e7-aaa8-e727114796d9",
        "length": 63,
        "createdAt": "2012-03-03T01:00:00Z",
        "dateCompleted": null
    }
}
```

**Response Body:**
```json
201 Created - The created game
{
    "meta": {},
    "data": {
        "id": "02d1d49a-ba59-4baf-8668-ed74edb5543d",
        "title": "Baldur's Gate 3",
        "status": "Playing",
        "console": "Sony Playstation 5",
        "format": "Special",
        "genre": "Western RPG",
        "length": 63,
        "createdAt": "2012-03-03T01:00:00Z",
        "updatedAt": null,
        "dateCompleted": null
    }
}
```


### Get Library (To be deprecated after Search Implementation):
---
```
GET /library
```

**Request Body:** None

**Response Body:**
```json
200 OK - The search results
{
    "meta": {
        "count": 3
    },
    "data": {
        "games" : [
            {
                "id": "02d1d49a-ba59-4baf-8668-ed74edb5543d",
                "title": "Persona 3 FES",
                "status": "finished",
                "console": {
                    "id": "5b8defdc-ea65-40e8-9fc7-54ab8d7ff05e",
                    "consoleName": "Sony Playstation 2"
                },
                "format": "collectors",
                "genre": {
                    "id": "11111111-b2f7-4b71-ab1d-b406350ae5fc",
                    "genreName": "Japanese RPG"
                },
                "length": 80,
                "createdAt": "2012-03-03T01:00:00Z",
                "updatedAt": null,
                "dateCompleted": "2012-08-19T01:00:00Z"
            },
            {
                "id": "d3201b32-1dd5-4545-94b4-e9edb5b1c79c",
                "title": "Xenoblade Chronicles 3",
                "status": "backlog",
                "console": {
                    "id": "84abfb03-f2f9-4113-aa83-4c4992be24c0",
                    "consoleName": "Nintendo Switch"
                },
                "format": "collectors",
                "genre": {
                    "id": "11111111-b2f7-4b71-ab1d-b406350ae5fc",
                    "genreName": "Japanese RPG"
                },
                "length": 53,
                "createdAt": "2022-07-26T01:00:00Z",
                "updatedAt": null,
                "dateCompleted": null
            },
            {
                "id": "e14b29d5-4151-447c-a56b-2806ff0caf7c",
                "title": "Factorio",
                "status": "playing",
                "console": {
                    "id": "7f775974-7dcd-4e29-a496-3048f57ff657",
                    "consoleName": "PC"
                },
                "format": "digital",
                "genre": {
                    "id": "fa565198-fc73-4f43-9010-9146a6a9b90e",
                    "genreName": "Puzzle"
                },
                "length": 18,
                "createdAt": "2022-07-26T01:00:00Z",
                "updatedAt": "2022-09-30T01:00:00Z",
                "dateCompleted": null
            }
        ]
    }
}
```


### Fetch Individual Game
---
`GET /library/{id}`

**Request Body:** None

**Response Body:**
```json
200 OK - The fetched game
{
    "meta": {},
    "data": {
        "id": "02d1d49a-ba59-4baf-8668-ed74edb5543d",
        "title": "Persona 3 FES",
        "status": "finished",
        "console": "Sony Playstation 2",
        "format": "collectors",
        "genre": "Japanese RPG",
        "length": 80,
        "createdAt": "2012-03-03T01:00:00Z",
        "updatedAt": "2022-09-30T01:00:00Z",
        "dateCompleted": "2012-08-19T01:00:00Z"
    }
}
```


### Update Game
---
```
PUT /library/{id}
```

**Request Body:**
```json
{
    "meta": {},
    "data": {
        "title": "Baldur's Gate 3",
        "status": "Finished",
        "consoleId": "c4b6474a-a2c5-4e4c-bdd5-5b4a156863ec",
        "format": "Special",
        "genreId": "82a091f6-4dba-47e7-aaa8-e727114796d9",
        "length": 63,
        "createdAt": "2012-03-03T01:00:00Z",
        "dateCompleted": "2015-07-23T01:00:00Z"
    }
}
```

**Response Body:**
```json
200 OK - The updated game
{
    "meta": {},
    "data": {
        "id": "02d1d49a-ba59-4baf-8668-ed74edb5543d",
        "title": "Baldur's Gate 3",
        "status": "Finished",
        "console": "Sony Playstation 5",
        "format": "Special",
        "genre": "Western RPG",
        "length": 63,
        "createdAt": "2012-03-03T01:00:00Z",
        "updatedAt": "2015-07-23T01:00:00Z",
        "dateCompleted": "2015-07-23T01:00:00Z"
    }
}
```


### Delete Game
---
`DELETE /library/{id}`

**Request Body:** None

**Response Body:** 
```json
204 No Content - The game was deleted
```