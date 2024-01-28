# Omni-GLM API Spec
Document Version 0.1

This spec outlines all endpoints and resources exposed by Omni-GLM. In addition, it also outlines the schema and model structures used to attain the desired behaviors. This is an ongoing project being built with ever-shifting requirements in mind, ergo this document should only be treated as comprehensive in the moment that it is updated. 

The roster of endpoints we'll begin with is modest (i.e. basic CRUD for games), but will grow over time and development. The intended workflow for the addition of endpoints is the following: 
```
Theorize UX => Add Endpoint to Spec => Alter Schema (if needed) => Implementation
```

## Update History
---
August 7, 2022 - Document Initialized, Data Tables and Models added, Get Entire Library route added. 


## API Resources
---
These are the outward facing REST resources exposed to the client. Many resources are categories being built with the intention of being expandable to include more instances of a category than what comes out of the box.

* **Game**: A game represents an entry in the user's library. It is the main resource of the project. 

* **Genre**: A category of gameplay style a game belongs to. It is one to many with games.

* **Console** A category of hardware a title is owned for. It is one to many with games.

## Data Tables
---
These are the server-side representations of the resources, while there will be correlation, they are not gauranteed to line up 100% with the code-side models. 

### Game:
```
ID - GUID (PK)
Title - String
GenreID - GUID (FK Genre)
ConsoleID - GUID (FK Console)
ReleaseDate - DateTime
Status - Enumified String
Length - Int
DateAdded - DateTime
DateCompleted - DateTime
BlockedBy - GUID (FK Game)
Format - Enumified String
Condition - Enumified String
Notes - Text
```

### Genre:
```
ID - GUID (PK)
GenreName - String
```

### Console:
```
ID - GUID (PK)
ConsoleName - String
```

## Data Models
---
The are the code-side representations of the data. The repository pattern will be used to keep these models as easy as possible to use. 

### Game: 
```
ID - GUID
Series? - Series
Genre - Genre
Console - Console
Release Date - DateTime
Status - Status
Length - Int
DateAdded? - DateTime
DateCompleted? - DateTime
BlockedBy? - Game
Format? - Format
Condition? - Condition
Notes? - String
```
### Series:
```
ID - GUID
SeriesTitle - String
```

### Genre:
```
ID - GUID 
GenreName - String
```

### Console:
```
ID - GUID 
ConsoleName - String
```

### Enum Status
```
Unfinished
Playing
Completed
Wishlist
LentOut
```

### Enum Format
```
Physical
Digital
CollectorsEdition
```

### Enum Condition
```
CompleteInBox
MissingInserts
Loose
```

## Endpoints
---

### Get Library:
---
```
GET /library
```

**Request Body:** None

**Response Body:**
```
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
                "series": {
                    "id": "88d1553f-b2f7-4b71-ab1d-b406350ae5fc",
                    "seriesTitle": "Persona"
                },
                "genre": {
                    "id": "11111111-b2f7-4b71-ab1d-b406350ae5fc",
                    "genreName": "JRPG"
                },
                "console": {
                    "id": "5b8defdc-ea65-40e8-9fc7-54ab8d7ff05e",
                    "consoleName": "Sony Playstation 2"
                },
                "releaseDate": "2007-19-04T01:00:00Z",
                "status": "complete",
                "length": 80,
                "dateAdded": "2012-03-03T01:00:00Z",
                "dateCompleted": "2012-19-08T01:00:00Z",
                "blockedBy": null,
                "format": "SpecialEdition",
                "condition": "CompleteInBox"
                "notes": null
            },
            {
                "id": "02d1d49a-ba59-4baf-8668-ed74edb5543d",
                "title": "Xenoblade Chronicles 3",
                "series": {
                    "id": "88d1553f-b2f7-4b71-ab1d-b406350ae5fc",
                    "seriesTitle": "Xeno"
                },
                "genre": {
                    "id": "11111111-b2f7-4b71-ab1d-b406350ae5fc",
                    "genreName": "JRPG"
                },
                "console": {
                    "id": "5b8defdc-ea65-40e8-9fc7-54ab8d7ff05e",
                    "consoleName": "Nintendo Switch"
                },
                "releaseDate": "2022-26-07T01:00:00Z",
                "status": "unfinished",
                "length": 53,
                "dateAdded": "2022-26-07T01:00:00Z",
                "dateCompleted": null,
                "blockedBy": {
                    "id": "02d1d49a-ba59-4baf-8668-ed74edb5543d",
                    "title": "Xenoblade Chronicles 2",
                    "series": {
                        "id": "88d1553f-b2f7-4b71-ab1d-b406350ae5fc",
                        "seriesTitle": "Xeno"
                    },
                    "genre": {
                        "id": "11111111-b2f7-4b71-ab1d-b406350ae5fc",
                        "genreName": "JRPG"
                    },
                    "console": {
                        "id": "5b8defdc-ea65-40e8-9fc7-54ab8d7ff05e",
                        "consoleName": "Nintendo Switch"
                    },
                    "releaseDate": "2017-01-07T01:00:00Z",
                    "status": "unfinished",
                    "length": 67,
                    "dateAdded": "2017-21-03T01:00:00Z",
                    "dateCompleted": null,
                    "blockedBy": null
                    "format": "SpecialEdition",
                    "condition": "CompleteInBox"
                    "notes": "Chapter 3 - in Uraya, met up with Vandham"
                },
                "format": "SpecialEdition",
                "condition": "MissingInserts"
                "notes": null
            }
        ]
    }
}
```

**Error Codes:** None

