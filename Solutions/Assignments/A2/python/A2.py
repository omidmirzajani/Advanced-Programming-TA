class Person:
    def __init__(self,id,name,contacts,chats):
        self.ID=id
        self.Name=name
        self.Contacts=contacts
        self.Chats=chats

    def AddContact(self,PERSON):
        isConnected=False
        for contact in self.Contacts:
            if(contact.ID==PERSON.ID):
                isConnected=True
        if(isConnected==False):
            self.Contacts.append(PERSON)
        self.Chats[PERSON.ID]=[]

    def SendMessage(self,message):
        self.AddContact(message.Destination)
        message.Destination.AddContact(self)
        
        self.Chats[message.Destination.ID].append(message)
        message.Destination.Chats[self.ID].append(message)    

class Message:
    def __init__(self,source,destination,context):
        self.Source=source
        self.Destination=destination
        self.Context=context


# person1=Person(97423156,"Mohammad",[],{})
# person2=Person(97521369,"Ramtin",[],{})
# person3=Person(97216432,"َAlireza",[],{})

# message12=Message(person1,person2,"Slm Khubi?")
# message31=Message(person2,person1,"Hello buddy!")

# person1.SendMessage(message12)
# person3.SendMessage(message31)
    
