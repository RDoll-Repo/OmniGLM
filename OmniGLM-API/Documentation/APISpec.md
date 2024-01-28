# Omni-GLM API Spec
This spec outlines all endpoints and resources exposed by Omni-GLM. In addition, it also outlines the schema and model structures used to attain the desired behaviors. This is an ongoing project being built with ever-shifting requirements in mind, ergo this document should only be treated as comprehensive in the moment that it is updated. 

The roster of endpoints we'll begin with is modest (i.e. basic CRUD for games), but will grow over time and development. The intended workflow for the addition of endpoints is the following: 
```
Theorize UX => Add Endpoint to Spec => Alter Schema (if needed) => Implementation
```

## API Resources
These are the outward facing REST resources exposed to the client. Many resources are categories being built with the intention of being expandable to include more instances of a category than what comes out of the box.

* **Game**: A game represents an entry in the user's library. It is the main resource of the project. 

* **Genre**: A category of gameplay style a game belongs to. It is one to many with games.

* **Console** A category of hardware a title is owned for. It is one to many with games.

## Data Tables
These are the server-side representations of the resources, while there will be correlation, they are not gauranteed to line up 100% with the code-side models. 

### Game:
```
id : GUID (PK)
title : String
status : Int (Enum Value)
console_id : GUID (FK Console)
format : Int (Enum Value)
genre_id : GUID (FK Genre)
length : Int
date_added : DateTime
date_completed : DateTime
```

### Genre:
```
id : GUID (PK)
title : String
```

### Console:
```
id : GUID (PK)
title : String
```

## Data Models
The are the code-side representations of the data. The repository pattern will be used to keep these models as easy as possible to work with. 

### Game: 
```
Id : GUID
Title : String
Status : Status
Console : Console
Format : Format
Genre : Genre
Length : Int
DateAdded : DateTime
DateCompleted? : DateTime
```

### Genre:
```
Id : GUID 
Title : String
```

### Console:
```
Id : GUID 
title : String
```

### Enum Status
```
Backlog
Playing
Finished
```

### Enum Format
```
Physical
Digital
Collectors
```

## Endpoints

### Get Library (To be deprecated after Search Implementation):
---
```
GET /library
```

**Request Body:** None

**Response Body:**
```json
Status 200 OK

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
                "dateAdded": "2012-03-03T01:00:00Z",
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
                "dateAdded": "2022-07-26T01:00:00Z",
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
                "dateAdded": "2022-07-26T01:00:00Z",
                "dateCompleted": null
            }
        ]
    }
}
```

**Error Codes:** None

