all: compile

compile: core specs

core:
	$(MAKE) -C Core

specs: core
	$(MAKE) compile -C Specifications 

test: specs
	$(MAKE) -C Specifications

report: specs
	$(MAKE) html-report -C Specifications

clean:
	$(MAKE) clean -C Core
	$(MAKE) clean -C Specifications
