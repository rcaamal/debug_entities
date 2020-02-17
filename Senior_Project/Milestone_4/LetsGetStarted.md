2019-20 Debug Entities. 
=====================================

## Summary of Our Approach to Software Development

[the process we are doing is creating the simulator for D&D and creating an ASP.Net webpage for further access.]  [For this project we are trying to improve the experience for users to be able to enjoy D&D and the detail and extent is to integrate books that are full of manuals for users to have a better access to them and then we can make the experience a more resourceful than other D&D’s]

## Initial Vision Discussion with Stakeholders

Vision Statement

For those who are interested in D&D and whom want to have a more accessible and streamlined experience, the Debug Entities website is both a tool kit and game running aid that will provide bookkeeping assistance as well as multiple visuals for facilitating interactions of the user and the often-complex aspects of the game. It will also contain visuals for the characters and items. Unlike other D&D simulators and games , our D&D: tool kit & Manager will have a rich search functionality so users can search through the many books in the database and find data from only what they need instead of wasting time going through hundreds of pages of hard-covered books manually.

Primary Stakeholder -- Kati Michael Phelpedecky, D&D Tool Kit

Kati Michael's who is a master of D&D and is the top-level player and knows what is expected of what is going to be needed to be the champion of D&D.  The problem is that is very time consuming that he has to spend hours searching through books to find what he is looking for to beat the game i.e. Monster Manual and Player handbook, he has book marked lots of pages that can help but his girlfriend always pulls them out to mess with him to stop playing the game and make him spend time with her. They want to create a D&D tool kit for new and expert users for them to have a better experience while playing the game and contain better functionality than other D&D’s. Kati Michael has assembled a team of investors to fund this project and is hiring your team to create the product.

The product is centered around three core features:

1. Filter search on specific items or creatures or tools to be found. Login features, saving settings, a populated database to be able to have more functionality to be able to make this project unique. Potently being mobility to have it be capable of traveling and still using our product. Capability to save players which would be part of the feature of the data base and search tool.
2. Having a useful UI evident data, with a turn manager, easy/ automatic changes to game entities, with memory to undo actions, that are used with an administrator would be features for bookkeeping assistants and this is to make things useful and able to stand out and make things easier for the user to make this experience better than previous ones.
3. Audio/Visuals would be designed with title-based map with icons, books visuals when they are available to make the visual a better design for the user. This core feature would also contain tutorials, voice scripts, step by step instructions which is something that would benefit those who never played D&D and who those who want to learn our product. Finally, it would contain sound effects with atmospheric music to draw the attention to users and have some kind of audio benefit to them and those who enjoy these types of features. 

## Initial Requirements Elaboration and Elicitation

### Questions

Q1: What is something you would like to see to make a past experience better than your first time playing?

Q2: Would you like to have most of the books that we use for D&D in this website with a search functionality?

Q3: What D&D was a great design or set up did you enjoy visual wise.?

Q4: Would you like a basic  step by step video on how to play D&D or how to use our website?

Q5: What functionality would you like to see in our D&D?

Q6: Is there any visuals that you would like to see that other D&D’s does not contain?

Q7: As a female user would you like something to make you welcomed?

Q8: Would like to make this an age restricted game or would any age be appropriate?

### Interviews

A1: Ways to keep track of player and non-player character armor class, hit points, and initiative. To allow for quick common rule checks on combat and saving throws vs skill checks.  

A2: YES! Flipping through 5 books of monsters and 3 player books is annoying when trying to create an encounter or making a new character. Races, feats and more are all welcome search features.

A3: Maps are a great tool in D&D. It is useful for combat, strategy, and town adventure. They take hours to create; however, a way to generate world, city, cave, and dungeons would be extremely helpful.

A4: Yes. A quick tutorial on how to use the website at its fullest is welcome.

A5: When creating maps, I would like to have access to the stores, characters that work in the stores and what’s available at what price. Also, who runs the town or the local area and what wildlife would be found in that area for surprise encounters.

A6: Pictures of common monsters and beasts to show the party as they are fighting them and then a token of that monster that can be placed on the interactive map so I can later move the tokens.

A7: No. As a female user there is no additional resources that I would need.

A8: Yes. There are many campaigns that have adult content and should be sectored for adults only.

### Other Elicitation Activities?

## List of Needs and Features

1. They want ways to keep track of a player and non-player character armor class, hit points, and initiative. To allow for quick common rule checks on combat and saving throws vs skill checks.
2. Players would like most of the books used for D&D with a search functionality because flipping through 5 books of monsters and 3 player books is annoying when trying to create an encounter or making a new character, races, feats.
3. Maps are a great tool in D&D. It is useful for combat, strategy, and town adventure. They take hours to create; however, a way to generate world, city, cave, and dungeons would be extremely helpful.
4. A quick tutorial on how to use the website at its fullest.
5. When creating maps, it be nice to have access to the stores, characters that work in the stores and what’s available at what price. Also, who runs the town or the local area and what wildlife would be found in that area for surprise encounters.
6. Pictures of common monsters and beasts to show the party as they are fighting them and then a token of that monster that can be placed on the interactive map so they can later move the tokens.
7. this D&D should be age restricted because there are many campaigns that have adult content and should be sectored for adults only.
8. There should be a login for users to use our website.


## Initial Modeling

### Use Case Diagrams

### Other Modeling

## Identify Non-Functional Requirements

1. User accounts and data must be stored indefinitely.  They want their accounts deleted when deleted.
2. Passwords should not expire
3. Site should never return debug error pages. If possible add a custom 404 page and link to go back home.
4. All server errors must be logged so we can investigate what is going on in a page accessible only to Admins.
5. English will be the default language.
6. The coloring of the website should appeal to all players, so it doesn’t seem to girly but not manly as well.

## Identify Functional Requirements (User Stories)

E: Epic  
U: User Story  
T: Task
C: Core Feature
 
1) [C] Have a search bar that you can filter easily
a. [E] As a user I want the ability to filter the database.
i. [U] As a user I want a modern, easy to navigate, home page. 
1. [T] Create an ASP dot MVC project.
2. [T] Create a nav-bar to important features including drop downs.
3. [T] Create a logo.
4. [T] Text that explains what the website is for.
5. [T] Nav Bar should always have the option to come back to this point.  
ii. [U] As a user I want a nice page that is easy to navigate to search the database.
1. [T] Create a database.
2. [T] Create a nice page that has a search bar. 
3. [T] Create a seed for the database the includes Spells, feats, and monsters.
4. [T] Use API to make the database less huge possibly?  
iii. [U] As a user I want to be able to easily define the parameters of my search.
1. [T] Create parameter drop downs that will allow us to define what they are searching for. 
2. [T] Make a navbar for the page that goes back to the home page.
3. [T] Make sure database can apply to those parameters.
iv. [U] As a user I want to be able to easily access both monsters and spells on the same page. 
1. [T] Make a drop down to switch between monsters and spells.
v. [U] As a user I want to be able to sort the filtered results.
1. [T] Sort the list before printing it to the page. 
vi. [U] As a user I want the filters to be below the search bar in a nice drop down so I can see how I can filter it.
1. [T] Use CSS and Html to organize the page.
2. [T] Make sure that the drop downs don’t cover up important information. 
b. [E] As a user I want to search the database.
i. [U] As a user I want to be able to search the database for monsters and spells.
1. [T] Create a search bar that has access to the monster table and the spells table (or use the api). 
ii. [U] As a user I would like to be able to get recommended searches from what I have already typed. 
1. [T] Use ajax to show the possible search results from what they have already typed. 
2. [T] Allow the possible search results to be clicked and bring up those stats.
iii. [U] As a user I want to have a search bar to do this in with a button to confirm my search.
1. [T] Create a physical button to press that will start the search action.
2. [T] Clear the search bar when the button is clicked.

2) [C] The ability to have the website keep track of and change all character’s and monster hit points, armor classes and initiative scores.  
a. [E] As a user I want to be able to have a list of my characters.
i. [U] As a user I need important character information displayed.
1. [T] Use ajax to display important information in organized boxes.
2. [T] Character information should be displayed on the left-hand side of the screen. 
ii. [U] As a user I need to be able to modify that information without reloading the page.
1. [T] Allow hit points, amor class, and initiative to be modified by user at any point. 
2. [T] Allow the character information to be modified by using ajax. 
iii. [U] As a user I need to be able to save the information for other sessions.
1. [T] Link their account to the players, monsters and maps.
2. [T] Create a save button to update or create them. 
3. [T] Remove dead monsters from the save
4. [T] Save everything under a name.
5. [T] Create a page where they can select a game to load.
iv. [U] As a user I need I need it to track how many spells my characters and monsters have left.
1. [T] Create 9 buttons, long rest button and short rest button
2. [T] When clicked the button should decrement.
3. [T] When the long rest button is clicked it should reset.
4. their spells for their appropriate levels and class.
5. [T] If the class gains doesn’t gain spell slots for a short rest the button should be hidden. 
6. [T] If the class does gain spell slots the appropriate number of slots should be displayed. 
b. [E] As a user I want the list of my characters to be sorted by initiative.
i. [U] Make a player model. 
ii. [U] As a user I need to it sorted without reloading the page.
1. [T] Put characters in a list to that is sorted highest to lowest.
2. [T] Modified stats should remain modified during the sort. 
c. [E] As a user I want to be able to search for monsters to add to the initiative line up. 
i. [U] As a user I want to be able to add and remove monsters from the line up and have it automatically rolled initiative and health. 
1. [T] Create a dice roll generator. 
2. [T] When adding monsters, it should either take their suggested health, or it should roll its health as described by the monster’s stat sheet. 
ii. [U] As a user I want be able to add monsters to the line up without reloading the page or losing any information I’ve input.
1. [T] Use ajax so reloading the page isn’t needed
2. [T] Create an add button that brings up the search bar for monsters. 
3. [T] When a monster is selected it should enter the line up by initiative in the correct spot. 
iii. [U] As a user I want the monster to be removed if its hit points >= 0
1. [T] Use ajax to check the health every time it changes.
2. [T] Modify the list to not include that monster. 
3. [T] This should not apply to players. 
3) [C] The website should have world, town, cave and dungeon map generation.
a. [E] As a user I want to be able to generate a town.
i. [U] As a user I want to be able to generate a tile-based town. 
ii. [U] As a user I want the town should have shops with items and cost.
iii. [U] As a user I want the town to have NPC names and races generated.
b. [E] As a user I want to be able to generate a cave. 
i. [U] As a user I want a tile-based cave.
ii. [U] As a user I want monster options to be available for me to search to put in the cave. 
iii. [U] As a user I want to be able to modify the map to put the 
iv. [U] As a user I want to be able to generate traps that are suitable for my parties’ level.
c. [E] As a user I want to be able to generate a dungeon.
i. [U] As a user I want a tile-based dungeon.
ii. [U] As a user I want to dictate the size of the dungeon (Small, medium, large)
iii. [U] As a user I want to be able to generate encounters or put them in myself.
iv. [U] As a user I want to be able to include or not include traps in the dungeon.  
d. [E] As a user I want to be able to generate a world map.
i. [U] As a user I want to be able to generate world maps that I can zoom in on without reloading the map.
ii. [U] As a user I want kingdoms, leaders, and terrain features to be defined


## Initial Architecture Envisioning

## Agile Data Modeling

## Timeline and Release Plan

