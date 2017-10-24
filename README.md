# ComicManagerDemo
This is a demo project of a basic comic book management API/Client

NOTES:
	There is currently no authentication. It uses the oldest authentication system known: the "Honor System"! This is currently just a barebones proof of concept for connecting the comic vine API and managing a local repo of objects

	This is an ASP Core Web API, uses MongoDB and is connected to comic vine

	You will need to supply your own key, which is currently being looked for in APIKey.txt in the local root folder. The eventual goal would be store this in the DB or elsewhere, encrypted, but since this project is barely a day old, bear with me

	This simplistic API will allow you to search comic vine for individual comics, publishers and full comic series. It also allows the management of a personal comic collection which can be added to, deleted from, updated and searched.


This uses Gamespot's Comic Vine API. You can find it here: https://comicvine.gamespot.com/api/
