pipeline {
  agent {
    node {
      label 'NET'
    }
    
  }
  stages {
	stage('Initial') {
		steps {
			echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}!"
		}
	}
  
    stage('Checkout') {
      steps {
        echo "Check out from Git repository ..."
		git(url: 'https://github.com/zengyulu/WPF-Samples', branch: '#refs/heads/master')
      }
    }
	
	stage('Nuget Restore') {
		steps {
			echo "Nuget restore packages"
			bat '${NUGET_FULLPATH} restore ${WORKSPACE}\WPFSamples.sln -OutputDirectory C:\\nuget'
		}
	}
	
	stage('MSBuild') {
		steps {
			echo "Start MSBuild"
			bat "\"${tool 'MSBuild'}\" ${WORKSPACE}\WPFSamples.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
		}
	}
  }
  environment {
    NUGET_FOLDER = 'C:\\nuget'
	NUGET_FULLPATH = 'C:\\nuget\\nuget.exe'
  }
}