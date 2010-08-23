all: compile

compile: core physical-entities specs

core:
	$(MAKE) -C Core
	
physical-entities: core
	$(MAKE) -C PhysicalEntities

specs: core physical-entities
	$(MAKE) compile -C Specifications 

test: specs
	$(MAKE) -C Specifications

report: specs
	$(MAKE) html-report -C Specifications

clean:
	$(MAKE) clean -C Core
	$(MAKE) clean -C PhysicalEntities
	$(MAKE) clean -C Specifications
