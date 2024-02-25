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
created_at : DateTime
updated_at : DateTime
date_completed : DateTime
```

### Genre:
```
id : GUID (PK)
title : String
created_at : DateTime
updated_at : DateTime
```

### Console:
```
id : GUID (PK)
title : String
created_at : DateTime
updated_at : DateTime
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
CreatedAt : DateTime
UpdatedAt : DateTime?
DateCompleted : DateTime?
```

### Genre:
```
Id : GUID 
Title : String
CreatedAt : DateTime
UpdatedAt : DateTime?
```

### Console:
```
Id : GUID 
title : String
CreatedAt : DateTime
UpdatedAt : DateTime?
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

## Controller Routes
Given the eventual size of this API, it is appropriate to divide what the bulk of this document would be, the API routes, into designated subsections as found below:

[Library](LibraryRoutes.md)

[Genres](GenreRoutes.md)

[Consoles](ConsoleRoutes.md)