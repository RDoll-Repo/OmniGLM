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
        "console": {
            "id": "482b78b3-a7cd-43ef-ab56-3b5f1befb737",
            "title": "Sony Playstation 5",
            "createdAt": "0001-01-01T00:00:00",
            "updatedAt": null
        },
        "format": "Special",
        "genre": {
            "id": "c6d46823-b71c-41fe-bc25-35546c5dfae3",
            "title": "Western RPG",
            "createdAt": "2024-04-27T05:15:30.064336Z",
            "updatedAt": null
        },
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
                "status": "Finished",
                "console": {
                    "id": "482b78b3-a7cd-43ef-ab56-3b5f1befb737",
                    "title": "Sony Playstation 2",
                    "createdAt": "0001-01-01T00:00:00",
                    "updatedAt": null
                },
                "format": "Special",
                "genre": {
                    "id": "c6d46823-b71c-41fe-bc25-35546c5dfae3",
                    "title": "Japanese RPG",
                    "createdAt": "2024-04-27T05:15:30.064336Z",
                    "updatedAt": null
                },
                "length": 80,
                "createdAt": "2012-03-03T01:00:00Z",
                "updatedAt": null,
                "dateCompleted": "2012-08-19T01:00:00Z"
            },
            {
                "id": "d3201b32-1dd5-4545-94b4-e9edb5b1c79c",
                "title": "Xenoblade Chronicles 3",
                "status": "Backlog",
                "console": {
                    "id": "482b78b3-a7cd-43ef-ab56-3b5f1befb737",
                    "title": "Nintendo Switch",
                    "createdAt": "0001-01-01T00:00:00",
                    "updatedAt": null
                },
                "format": "Special",
                "genre": {
                    "id": "c6d46823-b71c-41fe-bc25-35546c5dfae3",
                    "title": "Japanese RPG",
                    "createdAt": "2024-04-27T05:15:30.064336Z",
                    "updatedAt": null
                },
                "length": 53,
                "createdAt": "2022-07-26T01:00:00Z",
                "updatedAt": null,
                "dateCompleted": null
            },
            {
                "id": "e14b29d5-4151-447c-a56b-2806ff0caf7c",
                "title": "Factorio",
                "status": "Playing",
                "console": {
                    "id": "482b78b3-a7cd-43ef-ab56-3b5f1befb737",
                    "title": "PC",
                    "createdAt": "0001-01-01T00:00:00",
                    "updatedAt": null
                },
                "format": "Digital",
                "genre": {
                    "id": "c6d46823-b71c-41fe-bc25-35546c5dfae3",
                    "title": "Puzzle",
                    "createdAt": "2024-04-27T05:15:30.064336Z",
                    "updatedAt": null
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
        "status": "Finished",
        "console": {
            "id": "482b78b3-a7cd-43ef-ab56-3b5f1befb737",
            "title": "Sony Playstation 2",
            "createdAt": "0001-01-01T00:00:00",
            "updatedAt": null
        },
        "format": "Special",
        "genre": {
            "id": "c6d46823-b71c-41fe-bc25-35546c5dfae3",
            "title": "Japanese RPG",
            "createdAt": "2024-04-27T05:15:30.064336Z",
            "updatedAt": null
        },
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
        "console": {
            "id": "482b78b3-a7cd-43ef-ab56-3b5f1befb737",
            "title": "Sony Playstation 5",
            "createdAt": "0001-01-01T00:00:00",
            "updatedAt": null
        },
        "format": "Special",
        "genre": {
            "id": "c6d46823-b71c-41fe-bc25-35546c5dfae3",
            "title": "Western RPG",
            "createdAt": "2024-04-27T05:15:30.064336Z",
            "updatedAt": null
        },
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