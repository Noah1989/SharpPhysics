REFS = 

all: compile

compile: bin/SharpPhysics.Core.UnitsOfMeasurement.dll

bin/SharpPhysics.Core.UnitsOfMeasurement.dll: *.cs
	-mkdir bin
	gmcs -debug+ \
	     -out:bin/SharpPhysics.Core.UnitsOfMeasurement.dll -t:library \
	     $(patsubst %,-r:%,$(REFS)) \
	     *.cs

clean:
	-rm -r bin
