# Omni-GLM API Spec
This spec outlines all endpoints and resources exposed by Omni-GLM. In addition, it also outlines the schema and model structures used to attain the desired behaviors. This is an ongoing project being built with ever-shifting requirements in mind, ergo this document should only be treated as comprehensive in the moment that it is updated. 

The roster of endpoints we'll begin with is modest (i.e. basic CRUD for games), but will grow over time and development. The intended workflow for the addition of endpoints is the following: 
```
Theorize UX => Add Endpoint to Spec => Alter Schema (if needed) => Implementation
```

## API Resources
These are the outward facing REST resources exposed to the client. Many resources are categories being built with the intention of being expandable to include more instances of a category than what comes out of the box. I find it onerous to chart and maintain every model and corresponding table in this document, so a brief explanation of every resource will instead be written below. Implementation of the resources can be seen in the spec and code. 

* **Game**: A game represents an entry in the user's library. It is the main resource of the project. 

* **Genre**: A category of gameplay style a game belongs to. It is one to many with games.

* **Console** A category of hardware a title is owned for. It is one to many with games.


## Controller Routes
Given the eventual size of this API, it is appropriate to divide what the bulk of this document would be, the API routes, into designated subsections as found below:

[Library](LibraryRoutes.md)

[Genres](GenreRoutes.md)

[Consoles](ConsoleRoutes.md)
