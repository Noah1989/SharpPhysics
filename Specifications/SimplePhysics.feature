Feature: Simple Physics Simulations
	In order to do my physics homework
	I want to be able to simulate simple physics

Scenario: Free Fall
	Given a point mass
	And earth's gravity field
	When I simulate ten seconds of time
	Then the point mass should have a speed of 98.1 m/s
	And the point mass should have fallen 490.5 m
