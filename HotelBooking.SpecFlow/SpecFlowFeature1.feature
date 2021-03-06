﻿Feature: Manage Booking
	In order to make a booking
	As a customer
	I want to be able to see if I can book a room

@mytag
Scenario: Find an available room with invalid dates
	Given Startdate for the booking is in 0 day
	And Enddate for the booking is in 0 days
	When I look for a room
	Then I should get an error

Scenario: Find an available room with valid date
	Given Startdate for the booking is in 0 day
	And Enddate for the booking is in 1 days
	When I look for a room
	Then I should get a room ID

Scenario: Try to find an available room but get -1 as room id as no rooms available
	Given Startdate for the booking is in 5 day
	And Enddate for the booking is in 7 days
	When I look for a room
	Then I should get -1 as a room ID

Scenario: Find available room ID without going through more loop steps. Room ID is not -1
	Given Startdate for the booking is in 0 day
	And Enddate for the booking is in 3 days
	When I look for a room
	Then I should get a room ID

Scenario: Creating a booking with invalid dates
	Given Startdate for the booking is in 2 days
	And Enddate for the booking is in 5 days
	When I book a room
	Then I should get -1 instead of a legit room ID

Scenario Outline: Creating a booking in an occupied or unoccupied timeframe
	Given <Startdate> is supplied from today as startdate
	And <Endedate> is also supplied from today as enddate
	When I book a room
	Then return whether the booking is <Valid>

Examples:
	| Startdate	| Endedate	| Valid	|
	| 1			| 3			| true	|
	| 1			| 6			| false	|

Scenario: Creating a booking in an unoccupied timeframe and have booking be active
	Given Startdate for the booking is in 1 day
	And Enddate for the booking is in 3 days
	When I book a room
	Then The booking should be active
	

Scenario: Returning fully occupied rooms within a set of 2 dates
	Given Startdate for the booking is in 1 day
	And Enddate for the booking is in 30 days
	When I look for fully booked dates
	Then a list of fully occupied dates should be given

Scenario: Return empty list if no bookings within a set of 2 dates
	Given Startdate for the booking is in 45 day
	And Enddate for the booking is in 60 days
	When I look for fully booked dates
	Then an empty list of dates should be returned

Scenario: Return empty list if no fully occupied dates within a set of 2 dates
	Given Startdate for the booking is in 2 day
	And Enddate for the booking is in 3 days
	When I look for fully booked dates
	Then an empty list of dates should be returned

Scenario: Return not empty list if a mix of occupied and non-occupied rooms within a set of 2 dates
	Given Startdate for the booking is in 2 day
	And Enddate for the booking is in 7 days
	When I look for fully booked dates
	Then an empty list of dates shouldnt be returned

Scenario Outline: Find an available room with valid date using example table
	Given Startdate for the booking is in <Startdat2> day
	And Enddate for the booking is in <Endedat2> days
	When I look for a room
	Then I should get a room ID that is not <WrongResult>

Examples:
	| Startdat2	| Endedat2	| WrongResult	|
	| 120			| 125			| -1	|
	| 115			| 120			| -1	|
	| 125			| 127			| -1	|

Scenario Outline: Returning fully occupied rooms within a set of 2 dates using example table
	Given Startdate for the booking is in <Startdat3> day
	And Enddate for the booking is in <Endedat3> days
	When I look for fully booked dates
	Then a list of <FoundAnyFullyOccupiedDates> dates should be given

Examples:
	| Startdat3	| Endedat3	| FoundAnyFullyOccupiedDates	|
	| 235			| 245			| false	|
	| 215			| 230			| true	|
	| 220			| 228			| true	|
	| 220			| 230			| true	|
	#|Startdate2|Endedate2|Valid2|
	#|1|3|true|
	#|1|6|true|
	#|33|55|true|