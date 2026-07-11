print("\033c\033[47;31m\ngive me a text .txt file to encript ? ")
a=input().strip()
b=a.replace(".txt","")
f1=open(a,"r")
f=f1.read()
f1.close()
r=f.encode("utf-16")
counter=0

f1=open(b+".bin","bw")
f1.write(r)
f1.close()