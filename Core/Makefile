REFS = 

all: compile

compile: bin/SharpPhysics.Core.dll

bin/SharpPhysics.Core.dll: *.cs */*.cs
	-mkdir bin
	gmcs -debug+ \
	     -out:bin/SharpPhysics.Core.dll -t:library \
	     $(patsubst %,-r:%,$(REFS)) \
	     *.cs */*.cs

clean:
	-rm -r bin
