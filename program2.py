#Write a program to perform arithmetic operations
num1 = float(input('Please Enter the first number 1:'))
num2 = float(input('Please Enter the second number 2:'))
# Add Two Numbers
add = num1+num2
# Subtract Two Numbers
sub = num1-num2
# Multiply Two Numbers
multi = num1*num2
# Divide Two Numbers
div = num1/num2
# Modulus of num1 and num2
mod = num1%num2
# Exponent of num1 and num2
expo = num1**num2

print(" The Sum of {0}and{1} = {2}".format(num1,num2,add))
print(" The Subtraction of {0}and{1} = {2}".format(num1,num2,sub))
print(" The Multiplication of {0}and{1} = {2}".format(num1,num2,multi))
print(" The Division of {0}and{1} = {2}".format(num1,num2,div))
print(" The Modulus of {0}and{1} = {2}".format(num1,num2,mod))
print(" The Exponent of {0}and{1} = {2}".format(num1,num2,expo))

