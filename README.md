# async inn
< the only hotel chain where guests can come and go as they please... at the same time.

## summary
```
	The purpose of this application is to become intimately familiar with MVC through
	the creation of a hotel management system.
```

## example
![alt text](https://github.com/CClemensJr/AsyncInn/blob/master/AsyncInn/wwwroot/images/homepage.PNG)

## usage
```
	1. Run the application.
	2. Click on Hotels to manage hotels.
	3. Click on Rooms to manage rooms.
	4. Click on Amenities to manage amenities.
	5. Click on RoomAmenities to link amenities to existing rooms.
	6. Click on HotelRooms to add existing rooms to hotels.
```


## installation
```
	1. Click on green "Clone or download" button.
	2. Click on the clipboard.
	3. Clone the repository to your projects folder.
	4. Open the project in Visual Studio.
	5. Run the application.
```

## schema
![alt text](https://github.com/CClemensJr/AsyncInn/blob/master/AsyncInn/wwwroot/images/schema.PNG)

### overview
```
	A Hotel has many HotelRooms, but a HotelRoom can belong to only one Hotel.
	A HotelRoom can belong to only one Room but a Room can have many HotelRooms.
	A Room can have many RoomAmenities but RoomAmenities can only belong to one Room.
	Amenities can have many RoomAmenities but RoomAmenities can only have one Amenities.
```

### relationships
```
	A Hotel object contains the name, address, and phone number for each location. The HotelRoom table is
	a way of linking up Rooms to Hotels in the system. A Room is essentially a layout so each HotelRoom
	can only be based on one layout. These Room layouts also include the RoomAmenities which links
	the Room to the Amenities in the systen.
```

## author

* **Charles Clemens** - *Initial work* - [CClemensJr](https://github.com/CClemensJr)


## license
```
	This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
