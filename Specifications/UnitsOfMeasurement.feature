Feature: Units of Measurement
    In order to avoid mistakes
    I want physical values to have units of measurement

Scenario: Multiply two values
    Given a value of 220 volts
    And a value of 0.8 amperes
    When I multiply the two values
    Then the result should be 176 watts

Scenario: Divide two values
    Given a value of 9 volts
    And a value of 20 milliamperes
    When I divide the two values
    Then the result should be 450 ohms
    
Scenario: Add two values
    Given a value of 5 metres
    And a value of 3 metres
    When I add the two values
    Then the result should be 8 metres

Scenario: Substract two values
    Given a value of 5 volts
    And a value of 12 volts
    When I substract the two values
    Then the result should be -7 volts

Scenario: Units of measurement mismatch (adding)
    Given a value of 1 second
    And a value of 12 kilometres
    When I add the two values
    Then an UnitsOfMeasurementMismatchException should be thrown

Scenario: Units of measurement mismatch (substracting)
    Given a value of 360 volts
    And a value of 2 amperes
    When I substract the two values
    Then an UnitsOfMeasurementMismatchException should be thrown

