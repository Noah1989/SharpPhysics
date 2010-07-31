all: specs

core:
	$(MAKE) -C Core

specs: core
	$(MAKE) -C Specifications 

clean:
	$(MAKE) clean -C Core
	$(MAKE) clean -C Specifications
