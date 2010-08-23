REFS = ../Libraries/NUnit-2.5.5.10112/bin/net-2.0/framework/nunit.framework.dll \
       ../Libraries/SharpTestsEx1.0.0RTM/SharpTestsEx.NUnit.dll \
       ../Libraries/TechTalk/SpecFlow/TechTalk.SpecFlow.dll \
       ../Core/bin/SharpPhysics.Core.dll \
       ../PhysicalEntities/Mechanics/bin/SharpPhysics.PhysicalEntities.Mechanics.dll

all: run-tests

compile: bin/SharpPhysics.Specifications.dll
run-tests: TestResult.xml
html-report: 
	-$(MAKE) TestResult.xml
	$(MAKE) TestResult.html

Specifications.features: *.feature
	( \
	echo '<?xml version="1.0" encoding="utf-8"?> ';\
	echo '<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">';\
	echo '  <PropertyGroup>';\
	echo '    <RootNamespace>SharpPhysics.Specifications</RootNamespace>';\
	echo '    <AssemblyName>SharpPhysics.Specifications</AssemblyName>';\
	echo '  </PropertyGroup>';\
	echo '  <ItemGroup>';\
	for i in *.feature; do \
	echo '    <None Include="'$$i'">';\
	echo '      <Generator>SpecFlowSingleFileGenerator</Generator>';\
	echo '      <LastGenOutput>'$$i'.cs</LastGenOutput>';\
	echo '    </None>'; \
	done;\
	echo '  </ItemGroup>';\
	echo '</Project>' \
	) > Specifications.features

feature-cs-files: Specifications.features
	mono ../Libraries/TechTalk/SpecFlow/specflow.exe \
	generateall Specifications.features
	ls *.feature.cs > feature-cs-files

bin/SharpPhysics.Specifications.dll: feature-cs-files *.cs $(REFS)
	-mkdir bin
	gmcs -debug+ \
	     -out:bin/SharpPhysics.Specifications.dll -t:library \
	     $(patsubst %,-r:%,$(REFS)) \
	     *.cs
	cp $(REFS) bin/
	-cp $(patsubst %,%.mdb,$(REFS)) bin/

TestResult.xml: bin/SharpPhysics.Specifications.dll
	mono --debug \
	../Libraries/NUnit-2.5.5.10112/bin/net-2.0/nunit-console.exe \
	bin/SharpPhysics.Specifications.dll -labels

TestResult.html: TestResult.xml
	mono ../Libraries/TechTalk/SpecFlow/specflow.exe \
	nunitexecutionreport Specifications.features

clean:
	-rm Specifications.features
	-rm *.feature.cs
	-rm feature-cs-files
	-rm -r bin
	-rm TestResult.*
