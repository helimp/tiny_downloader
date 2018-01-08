# tiny_downloader
Tiny downloader can be commited to repo and the user can quickly download 3rd party requirement (especially to download specification documents of large size that can not be committed to keep source-code light weighted)

## Who will need this
- Developer who wants to keep source-code repository light-weighted
- Who require some 3rd party documents to be fetched from URL to keep them up-to-date

## How to use
Pre-requirements:
- Dotnet framework 3.5

Steps to commit:
- Build the project and generate ``Downloader.exe`` file (at /bin/Release/Downloader.exe)
- Create folder ``docs`` inside your repository
- Copy the ``Downloader.exe`` file into ``docs`` folder
- Create ``Downloader.ini`` file inside ``docs`` folder and write following formatted content
    ```
    [FILES]
    1=Debian Handbook|https://debian-handbook.info/download/stable/debian-handbook.pdf
    2=Centos Installation Guide|https://nsdg.gov.in/manual/CentOSInstallationManual.pdf
    ```
- You can add more entries numberd as 3, 4, etc... into the ``Downloader.ini`` file
- Now commit these two files ``Downloader.exe`` and ``Downloader.ini`` to the repository

Steps to fetch:
- Pull the repository and open ``docs`` folder
- Execute the ``Downloader.exe`` file and you will find all two entries you have added to the INI file above will be shown in the list as selected
- Click on ``Download`` button and wait for the download finish.
- You will see all two files downloaded under the docs directory and ready to refer

Conclusion:
- The large documents(pdfs) was not stored on repository that will save your space
- Clone repository quickly (only main source code will be downloaded from repository - the documents are already hosted by 3rd party systems so that can be downloaded seperately without storing into the repository)
