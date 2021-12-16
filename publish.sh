#!/bin/bash

# git pull
PUBLISH_TARGET="/var/www/app-"
PUBLISH_TARGET+=`date +%s`
dotnet publish -c Release -o $PUBLISH_TARGET
ln -sfn $PUBLISH_TARGET /var/www/BalbDemoApp
systemctl restart BalbDemoApp
