Feature: Trigonomische Funktionen
Als Taschenrechner Benützer
möchte ich trigonomische funktionen Berechnen können
damit ich ein Dreieck berechnen lassen kann

@mytag
Scenario: sinus
	Given the first number is 3.14159
	When we calculate the sinus from it
	Then the result should be 0

	@mytag
Scenario: cosinus
	Given the first number is 3.14159
	When we calculate the cosinus from it
	Then the result should be -1

	@mytag
Scenario: tangens
	Given the first number is 3.14159
	When we calculate the tangens from it
	Then the result should be 0