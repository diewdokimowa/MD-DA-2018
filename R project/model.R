library(caret)
library(optparse)
library(dplyr)

option_list <- list(
  make_option(c('--applications'), action='store', default=NA, type='double')
)
opt = parse_args(OptionParser(option_list=option_list))

load('../../dataset.Rda')

linear.model <- lm(Likes ~ Applications, data=data)

# grab p-value, R-squared and Adjusted R-squared
summary(linear.model)

# print prediction result (how much comments should be under the post)
predict(linear.model, data.frame(Applications=opt$applications))[[1]]

# model testing
train <- createDataPartition(data, p=0.7, list=F)
data.training <- data[train,]
data.test <- data[-train,]

model <- lm(Likes ~ Applications, data=data.training)
model.prediction <- predict(model, data.test)

# show in interface, smaller number is better
# Mean Absolute Error
MAE(model.prediction, data.test$Applications)
