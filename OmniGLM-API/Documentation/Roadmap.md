# Phase Roadmap
This document outlines features to be implemented and some broad "phases" in which they will be implemented. Note that this document only applies to the API and not to any other modules such as the React web client. 

## Phase I: CRUD Prototype
**Status: In-Progress**

**1/27/2024 - TBA**

The purpose of this phase is to take the simplest form of this project and make it functional. Our three starting resources are Games, Genres, and Consoles. We will expand this list later in development, but for now we just need to be able to completely manipulate the data for them via the API.

At the end of this phase, we should have a functioning, albeit barebones API that we will be able to interact with via a prototyped React client. Ultimately, this should be the point where the API can do everything the old VB.NET version of this project could. 

|       | Tasks                                                 |
|-------|-------------------------------------------------------|
|&check;| Scaffold API and set up EF Core                       |
|&check;| Initial documentation                                 |
|&#9744;| Game CRUD                                             |
|&#9744;| Genre CRUD                                            |
|&#9744;| Console CRUD                                          |
|&#9744;| Game Search Route                                     |
|&#9744;| Random Game Suggestion                                |
|&#9744;| Cleanup and final integration test with React client  |

## Phase II: Polished MVP
**Status: Upcoming**

**TBA - TBA**

Initial hopes for this phase will include error handling, and unit tests- potentially auth as well contingent on the results of research asking if it should be done with my current equipment. If possible, we could try to sneak one user story in during this phase, but it will mostly be focused on polishing the project with considerations one would expect a fully-functional API to have.

|       | Tasks                                                 |
|-------|-------------------------------------------------------|
|&#9744;| Error Handling                                        |
|&#9744;| Unit tests                                            |
|&#9744;| Auth                                                  |
|&#9744;| Fully define README                                   |
|&#9744;| Github integration (IE: PR Templates)                 |
|&#9744;| Additional tasks TBD....                              |

## Future Features
This section is for outlining the features I would like to incorporate but have no place in the forseeable timeline as of yet. 

- Library completion stats
- Box art fetching
- HLTB estimate fetching
- The following fields for games
  - `Series` - the series a game belongs to
  - `BlockedBy` - so that the API doesn't recommend games that the user doesn't want to play before a given on is finished (IE: playing a sequel before the original)
  - `Notes` - for the user to jot down thoughts (IE: they may want to write a reminder of where they left off in a game if they know they'll be dropping it for a while.)
- More sophisticated recommendations
