#------------------------------------------------------------------------------#
# This makefile was generated by 'cbp2make' tool rev.147                       #
#------------------------------------------------------------------------------#


WORKDIR = `pwd`

CC = gcc
CXX = g++
AR = ar
LD = g++
WINDRES = windres

INC = 
CFLAGS = 
RESINC = 
LIBDIR = 
LIB = 
LDFLAGS = 
SolutionDir = ../../

INC_DEBUG_X64 = $(INC) -I$(NF_HOME) -I$(BOOST_HOME) -I$(NF_DEP) -I$(NF_LIBEVENT) -I$(NF_DEP)/libevent-2.0.21-stable/include -I$(NF_DEP)/libevent-2.0.21-stable/WIN32-Code -I$(NF_DEP)/libevent-2.0.21-stable/compat -I$(NF_DEP)/protobuf-2.5.0/src -I$(THERON_HOME)
CFLAGS_DEBUG_X64 = $(CFLAGS) -DWIN -D_DEBUG -D_WINDOWS -D_USRDLL -DTHERON_CPP11
RESINC_DEBUG_X64 = $(RESINC)
RCFLAGS_DEBUG_X64 = $(RCFLAGS)
LIBDIR_DEBUG_X64 = $(LIBDIR) -L$(NFBIN_COMM)/$(Configuration) -L$(APP_DEPLIB)/$(Configuration)
LIB_DEBUG_X64 = $(LIB)
LDFLAGS_DEBUG_X64 = $(LDFLAGS)
OBJDIR_DEBUG_X64 = .objs
DEP_DEBUG_X64 = 
OUT_DEBUG_X64 = /NFLuaScriptPlugin.so

INC_RELEASE_X64 = $(INC) -I$(NF_HOME) -I$(BOOST_HOME) -I$(NF_DEP) -I$(NF_LIBEVENT) -I$(NF_DEP)/libevent-2.0.21-stable/include -I$(NF_DEP)/libevent-2.0.21-stable/WIN32-Code -I$(NF_DEP)/libevent-2.0.21-stable/compat -I$(NF_DEP)/protobuf-2.5.0/src -I$(THERON_HOME)
CFLAGS_RELEASE_X64 = $(CFLAGS) -DWIN -D_WINDOWS -D_USRDLL -DTHERON_CPP11
RESINC_RELEASE_X64 = $(RESINC)
RCFLAGS_RELEASE_X64 = $(RCFLAGS)
LIBDIR_RELEASE_X64 = $(LIBDIR) -L$(NFBIN_COMM)/$(Configuration) -L$(APP_DEPLIB)/$(Configuration)
LIB_RELEASE_X64 = $(LIB)
LDFLAGS_RELEASE_X64 = $(LDFLAGS)
OBJDIR_RELEASE_X64 = .objs
DEP_RELEASE_X64 = 
OUT_RELEASE_X64 = /NFLuaScriptPlugin.so

OBJ_DEBUG_X64 = $(OBJDIR_DEBUG_X64)/NFCLuaScriptModule.o $(OBJDIR_DEBUG_X64)/NFLuaScriptPlugin.o $(OBJDIR_DEBUG_X64)/dllmain.o

OBJ_RELEASE_X64 = $(OBJDIR_RELEASE_X64)/NFCLuaScriptModule.o $(OBJDIR_RELEASE_X64)/NFLuaScriptPlugin.o $(OBJDIR_RELEASE_X64)/dllmain.o

all: debug_x64 release_x64

clean: clean_debug_x64 clean_release_x64

before_debug_x64: 
	test -d $(OBJDIR_DEBUG_X64) || mkdir -p $(OBJDIR_DEBUG_X64)

after_debug_x64: 

debug_x64: before_debug_x64 out_debug_x64 after_debug_x64

out_debug_x64: before_debug_x64 $(OBJ_DEBUG_X64) $(DEP_DEBUG_X64)
	$(LD) -shared $(LIBDIR_DEBUG_X64) $(OBJ_DEBUG_X64)  -o $(OUT_DEBUG_X64) $(LDFLAGS_DEBUG_X64) $(LIB_DEBUG_X64)

$(OBJDIR_DEBUG_X64)/NFCLuaScriptModule.o: NFCLuaScriptModule.cpp
	$(CXX) $(CFLAGS_DEBUG_X64) $(INC_DEBUG_X64) -c NFCLuaScriptModule.cpp -o $(OBJDIR_DEBUG_X64)/NFCLuaScriptModule.o

$(OBJDIR_DEBUG_X64)/NFLuaScriptPlugin.o: NFLuaScriptPlugin.cpp
	$(CXX) $(CFLAGS_DEBUG_X64) $(INC_DEBUG_X64) -c NFLuaScriptPlugin.cpp -o $(OBJDIR_DEBUG_X64)/NFLuaScriptPlugin.o

$(OBJDIR_DEBUG_X64)/dllmain.o: dllmain.cpp
	$(CXX) $(CFLAGS_DEBUG_X64) $(INC_DEBUG_X64) -c dllmain.cpp -o $(OBJDIR_DEBUG_X64)/dllmain.o

clean_debug_x64: 
	rm -f $(OBJ_DEBUG_X64) $(OUT_DEBUG_X64)
	rm -rf $(OBJDIR_DEBUG_X64)

before_release_x64: 
	test -d $(OBJDIR_RELEASE_X64) || mkdir -p $(OBJDIR_RELEASE_X64)

after_release_x64: 

release_x64: before_release_x64 out_release_x64 after_release_x64

out_release_x64: before_release_x64 $(OBJ_RELEASE_X64) $(DEP_RELEASE_X64)
	$(LD) -shared $(LIBDIR_RELEASE_X64) $(OBJ_RELEASE_X64)  -o $(OUT_RELEASE_X64) $(LDFLAGS_RELEASE_X64) $(LIB_RELEASE_X64)

$(OBJDIR_RELEASE_X64)/NFCLuaScriptModule.o: NFCLuaScriptModule.cpp
	$(CXX) $(CFLAGS_RELEASE_X64) $(INC_RELEASE_X64) -c NFCLuaScriptModule.cpp -o $(OBJDIR_RELEASE_X64)/NFCLuaScriptModule.o

$(OBJDIR_RELEASE_X64)/NFLuaScriptPlugin.o: NFLuaScriptPlugin.cpp
	$(CXX) $(CFLAGS_RELEASE_X64) $(INC_RELEASE_X64) -c NFLuaScriptPlugin.cpp -o $(OBJDIR_RELEASE_X64)/NFLuaScriptPlugin.o

$(OBJDIR_RELEASE_X64)/dllmain.o: dllmain.cpp
	$(CXX) $(CFLAGS_RELEASE_X64) $(INC_RELEASE_X64) -c dllmain.cpp -o $(OBJDIR_RELEASE_X64)/dllmain.o

clean_release_x64: 
	rm -f $(OBJ_RELEASE_X64) $(OUT_RELEASE_X64)
	rm -rf $(OBJDIR_RELEASE_X64)

.PHONY: before_debug_x64 after_debug_x64 clean_debug_x64 before_release_x64 after_release_x64 clean_release_x64

