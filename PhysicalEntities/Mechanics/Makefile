REFS = ../../Core/bin/SharpPhysics.Core.dll

all: compile

compile: bin/SharpPhysics.PhysicalEntities.Mechanics.dll

bin/SharpPhysics.PhysicalEntities.Mechanics.dll: *.cs
	-mkdir bin
	gmcs -debug+ \
	     -out:bin/SharpPhysics.PhysicalEntities.Mechanics.dll -t:library \
	     $(patsubst %,-r:%,$(REFS)) \
	     *.cs

clean:
	-rm -r bin
